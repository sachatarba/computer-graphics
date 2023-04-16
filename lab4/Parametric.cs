using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Parametric
    {
        public static List<Point> GetPointsForCircle(Point center, int radius)
        {
            List<Point> points = new List<Point>();

            float addition = 1f / radius;
            int x = 0, y = 0;

            for (float i = 0; i < Math.PI / 4  + addition; i += addition)
            {
                x = Convert.ToInt32(center.X + radius * Math.Cos(i));
                y = Convert.ToInt32(center.Y + radius * Math.Sin(i));
                points.AddRange(Painter.ReflectPointsOfCircle(new Point(x, y), center));
            }

            return points;
        }

        public static List<Point> GetPointsForEllipse(Point center, int heigth, int width)
        {
            List<Point> points = new List<Point>();

            float addition = 0;
            if (width > heigth) 
            {
                addition = 1f / width;
            }
            else
            {
                addition = 1f / heigth;
            }

            int x = 0, y = 0;

            for (float i = 0; i <= Math.PI / 2 + addition; i += addition)
            {
                x = center.X + Convert.ToInt32(width * Math.Cos(i));
                y = center.Y + Convert.ToInt32(heigth * Math.Sin(i));
                points.AddRange(Painter.ReflectPointsOfEllipse(new Point(x, y), center));
            }

            return points;
        }
    }
}
