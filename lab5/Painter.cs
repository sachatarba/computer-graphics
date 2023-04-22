using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Painter
    {
        public static void DrawLines(Graphics g, List<Point> points, Color color)
        {
            Pen pen = new Pen(color);
            
            if (points.Count >= 2)
            {
                g.DrawLines(pen, points.ToArray());
            }
        }

        public static void FillFigure(Bitmap m, List<Point> points, Color color)
        {
            int leftBorder = points.Min(p => p.X);
            int rightBorder = points.Max(p => p.X);
            int topBorder = points.Max(p => p.Y);
            int bottomBorder = points.Min(p => p.Y);

            for (int y = topBorder; y >= bottomBorder; --y)
            {
                bool is_inside = false;

                for (int x = leftBorder; x <= rightBorder; ++x) 
                {
                    if (m.GetPixel(x, y) == Color.Black)
                    {
                        is_inside = !is_inside;
                    }

                    if (is_inside)
                    {
                        m.SetPixel(x, y, color);
                    }
                }
            }
        }
    }
}
