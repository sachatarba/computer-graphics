using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Algorithm
    {
        public enum RegionCode
        {
            Inside = 0,
            Left = 1,
            Right = 2,
            Bottom = 4,
            Top = 8
        }

        public static RegionCode GetRegionCode(float x, float y, float xmin, float xmax, float ymin, float ymax)
        {
            RegionCode code = RegionCode.Inside;

            if (x < xmin)
            {
                code |= RegionCode.Left;
            }
            else if (x > xmax)
            {
                code |= RegionCode.Right;
            }

            if (y < ymin)
            {
                code |= RegionCode.Bottom;
            }
            else if (y > ymax)
            {
                code |= RegionCode.Top;
            }

            return code;
        }

        public static void ClipLine(float x0, float y0, float x1, float y1, float xmin, float xmax, float ymin, float ymax,
            out float xx0, out float yy0, out float xx1, out float yy1)
        {
            RegionCode code0 = GetRegionCode(x0, y0, xmin, xmax, ymin, ymax);
            RegionCode code1 = GetRegionCode(x1, y1, xmin, xmax, ymin, ymax);

            while (true)
            {
                if ((code0 | code1) == RegionCode.Inside)
                {
                    // Линия полностью видима
                    xx0 = x0;
                    yy0 = y0;
                    xx1 = x1;
                    yy1 = y1;
                    return;
                }
                else if ((code0 & code1) != RegionCode.Inside)
                {
                    // Линия полностью невидима
                    xx0 = 0;
                    yy0 = 0;
                    xx1 = 0;
                    yy1 = 0;
                    return;
                }
                else
                {
                    // Линия частично видима
                    float x, y;

                    RegionCode outcode = code0 != RegionCode.Inside ? code0 : code1;

                    if ((outcode & RegionCode.Top) != 0)
                    { // Линия проходит через верхнюю границу
                        x = x0 + (x1 - x0) * (ymax - y0) / (y1 - y0);
                        y = ymax;
                    }
                    else if ((outcode & RegionCode.Bottom) != 0)
                    { // Линия проходит через нижнюю границу
                        x = x0 + (x1 - x0) * (ymin - y0) / (y1 - y0);
                        y = ymin;
                    }
                    else if ((outcode & RegionCode.Right) != 0)
                    {  // Линия проходит через правую границу
                        y = y0 + (y1 - y0) * (xmax - x0) / (x1 - x0);
                        x = xmax;
                    }
                    else
                    { // Линия проходит через левую границу
                        y = y0 + (y1 - y0) * (xmin - x0) / (x1 - x0);
                        x = xmin;
                    }

                    if (outcode == code0)
                    {
                        x0 = x;
                        y0 = y;
                        code0 = GetRegionCode(x0, y0, xmin, xmax, ymin, ymax);
                    }
                    else
                    {
                        x1 = x;
                        y1 = y;
                        code1 = GetRegionCode(x1, y1, xmin, xmax, ymin, ymax);
                    }
                }
            }
        }
        
        public static List<(Point, Point, Color)> GetIntersectedLine(List<(Point, Point, Color)> lines, Rectangle rect, Color newColor)
        {
            List<(Point, Point, Color)> intersectedLines =  new List<(Point, Point, Color)>();

            foreach (var line in lines)
            {
                ClipLine(line.Item1.X, line.Item1.Y, line.Item2.X, line.Item2.Y, rect.X, rect.X + rect.Width, rect.Y, rect.Y + rect.Height,
                    out float x0, out float y0, out float x1, out float y1);
                intersectedLines.Add((new Point((int)x0, (int)y0), new Point((int)x1, (int)y1), newColor));
            }

            return intersectedLines;
        }

    }
}
