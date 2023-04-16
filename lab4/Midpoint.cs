using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Midpoint
    {
        public static List<Point> GetPointsForCircle(Point center, int radius)
        {
            List<Point> points = new List<Point>();

            int x = radius;
            int y = 0;
            int delta = 1 - radius;

            points.AddRange(Painter.ReflectPointsOfCircle(new Point(x + center.X, y + center.Y), center));

            while (x >= y)
            {
                if (delta > 0)
                {
                    --x;
                    ++y;
                    delta += 2 * y + 1 - 2 * x;
                }
                else
                {
                    ++y;
                    delta += 2 * y + 1;
                }

                points.AddRange(Painter.ReflectPointsOfCircle(new Point(x + center.X, y + center.Y), center));
            }

            return points;
        }


        public static List<Point> GetPointsForEllipse(Point center, int heigth, int width) 
        {
            List<Point> points = new List<Point>();

            int sqrWidth = width * width;
            int sqrHeigth = heigth * heigth;

            int x = 0;
            int y = heigth;
            
            int delta = sqrHeigth - Convert.ToInt32(sqrWidth * (heigth - 1f / 4));
            int endWidth = Convert.ToInt32(width / Math.Sqrt(1 + Convert.ToSingle(sqrHeigth) / sqrWidth));

            points.AddRange(Painter.ReflectPointsOfEllipse(new Point(x + center.X, y + center.Y), center));
            while (x <= endWidth)
            {
                if (delta < 0)
                {
                    ++x;
                    delta += 2 * sqrHeigth * x + 1;
                }
                else
                {
                    ++x;
                    --y;
                    delta = 2 * sqrHeigth * x - 2 * sqrWidth * y + 1;
                }

                points.AddRange(Painter.ReflectPointsOfEllipse(new Point(x + center.X, y + center.Y), center));
            }

            x = width;
            y = 0;

            delta = sqrWidth - Convert.ToInt32(sqrHeigth * (width - 1f / 4));
            int endHeight = Convert.ToInt32(heigth / Math.Sqrt(1 + Convert.ToSingle(sqrWidth) / sqrHeigth));

            points.AddRange(Painter.ReflectPointsOfEllipse(new Point(x + center.X, y + center.Y), center));
            while (y <= endHeight)
            {
                if (delta < 0)
                {
                    ++y;
                    delta += 2 * sqrWidth * y + 1;
                }
                else
                {
                    --x;
                    ++y;
                    delta = 2 * sqrWidth * y - 2 * sqrHeigth * x + 1;
                }

                points.AddRange(Painter.ReflectPointsOfEllipse(new Point(x + center.X, y + center.Y), center));
            }

            return points;
        }
    }
}
