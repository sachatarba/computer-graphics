using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Brezenhem
    {
        public static List<Point> GetPointsByOctant(Point center, int radius)
        {
            List<Point> points = new List<Point>();
            
            int x = 0;
            int y = radius;

            points.AddRange(Painter.ReflectPointsOfCircle(new Point(x + center.X, y + center.Y), center));
            int delta = 2 * (1 - radius);
            int d = 0;

            while (y >= x)
            {
                d = 2 * (delta + y) - 1;
                ++x;

                if (d >= 0)
                {
                    --y;
                    delta += 2 * (x - y + 1);
                }
                else
                {
                    delta += 2 * x + 1;
                }

                points.AddRange(Painter.ReflectPointsOfCircle(new Point(x + center.X, y + center.Y), center));
            }

            return points;
        }

        public static List<Point> GetPointsForEllipse(Point center, int height, int width)
        {
            List<Point> points = new List<Point>();

            int x = 0;
            int y = height;

            int sqrOfWidth = width * width;
            int sqrOfHeight = height * height;
            int delta = sqrOfHeight - sqrOfWidth * (2 * height + 1);
            int d1 = 0, d2 = 0;

            while (y >= 0)
            {
                if (delta < 0)
                {
                    d1 = 2 * delta + sqrOfWidth * (2 * y + 2);
                    ++x;

                    if (d1 < 0)
                    {
                        delta += sqrOfHeight * (2 * x + 1);
                    }
                    else
                    {
                        --y;
                        delta += sqrOfHeight * (2 * x + 1) + sqrOfWidth * (1 - 2 * y);
                    }
                }
                else if (delta > 0)
                {
                    d2 = 2 * delta + sqrOfHeight * (2 - 2 * x);
                    --y;

                    if (d2 > 0)
                    {
                        delta += sqrOfWidth * (1 - 2 * y);
                    }
                    else 
                    {
                        ++x;
                        delta += sqrOfHeight * (2 * x + 1) + sqrOfWidth * (1 - 2 * y);
                    }
                }
                else
                {
                    --y;
                    ++x;
                    delta += sqrOfHeight * (2 * x + 1) + sqrOfWidth * (1 - 2 * y);
                }

                points.AddRange(Painter.ReflectPointsOfEllipse(new Point(x + center.X, y + center.Y), center));
            }

            return points;
        }
    }
}
