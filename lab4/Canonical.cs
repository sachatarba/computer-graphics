using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Canonical
    {
        public static List<Point> GetPointsForCircle(Point center, int radius)
        {
            List<Point> points = new List<Point>();

            int sqrRadius = radius * radius;
            int end = Convert.ToInt32(center.X + radius / Math.Sqrt(2));
            int y = 0;

            for (int x = center.X; x < end + 1; ++x) 
            {
                y = Convert.ToInt32(center.Y + Math.Sqrt(sqrRadius - (x - center.X) * (x - center.X)));
                points.AddRange(Painter.ReflectPointsOfCircle(new Point(x, y), center));
            }

            return points;
        }


        public static List<Point> GetPointsForEllipse(Point center, int heigth, int width)
        {
            List<Point> points = new List<Point>();

            int sqrWidth = width * width;
            int sqrHeight = heigth * heigth;
            int widthEnd = Convert.ToInt32(center.X + width / Math.Sqrt(1 + sqrHeight / sqrWidth));
            int heightEnd = Convert.ToInt32(center.Y + heigth / Math.Sqrt(1 + sqrWidth / sqrHeight));

            for (int x = center.X, y = 0; x < widthEnd + 1; ++x)
            {
                y = Convert.ToInt32(center.Y + Math.Sqrt(sqrWidth * sqrHeight - (x - center.X) * (x - center.X) * sqrHeight) / width);
                points.AddRange(Painter.ReflectPointsOfEllipse(new Point(x, y), center));
            }

            for (int y = center.Y, x = 0; y < heightEnd + 1; ++y)
            {
                x = Convert.ToInt32(center.X + Math.Sqrt(sqrWidth * sqrHeight - (y - center.Y) * (y - center.Y) * sqrWidth) / heigth);
                points.AddRange(Painter.ReflectPointsOfEllipse(new Point(x, y), center));
            }

            return points;
        }
    }
}
