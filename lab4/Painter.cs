using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Painter
    {
        public delegate void DrawEllipseFunc(Graphics g, PointF center, int width, int height, Color color);

        public static void DrawEllipseLib(Graphics g, PointF center, int width, int height, Color color)
        {
            Pen pen = new Pen(color);
            g.DrawEllipse(pen, center.X - width, center.Y - height, width * 2, height * 2);
        }

        public static void DrawCircleBrezenhem(Graphics g, PointF center, int width, int heigth, Color color)
        {
            Pen pen = new Pen(color);
            List<Point> points = Brezenhem.GetPointsByOctant(new Point(Convert.ToInt32(center.X), Convert.ToInt32(center.Y)), width);

            foreach (Point point in points)
            {
                g.DrawEllipse(pen, point.X, point.Y, 1, 1);
            }
        }

        public static void DrawCircleCanonical(Graphics g, PointF center, int width, int heigth, Color color)
        {
            Pen pen = new Pen(color);
            List<Point> points = Canonical.GetPointsForCircle(new Point(Convert.ToInt32(center.X), Convert.ToInt32(center.Y)), width);

            foreach (Point point in points)
            {
                g.DrawEllipse(pen, point.X, point.Y, 1, 1);
            }
        }

        public static void DrawEllipseCanonical(Graphics g, PointF center, int width, int heigth, Color color)
        {
            Pen pen = new Pen(color);
            List<Point> points = Canonical.GetPointsForEllipse(new Point(Convert.ToInt32(center.X), Convert.ToInt32(center.Y)), heigth, width);

            foreach (Point point in points)
            {
                g.DrawEllipse(pen, point.X, point.Y, 1, 1);
            }
        }


        public static void DrawEllipseBrezenhem(Graphics g, PointF center, int width, int heigth, Color color)
        {
            Pen pen = new Pen(color);
            List<Point> points = Brezenhem.GetPointsForEllipse(new Point(Convert.ToInt32(center.X), Convert.ToInt32(center.Y)), heigth, width);

            foreach (Point point in points)
            {
                g.DrawEllipse(pen, point.X, point.Y, 1, 1);
            }
        }

        public static void DrawScene(Graphics g, List<IDrawable> drawablesObjects)
        {
            foreach (var drawable in drawablesObjects)
            {
                drawable.DrawObject(g);
            } 
        }

        public static List<Point> ReflectPointsOfCircle(Point point, Point center)
        {
            List<Point> points = new List<Point>();

            points.Add(new Point(point.Y - center.Y + center.X, point.X - center.X + center.Y));
            points.Add(new Point(-point.Y + center.Y + center.X, point.X - center.X + center.Y));
            points.Add(new Point(point.Y - center.Y + center.X, -point.X + center.X + center.Y));
            points.Add(new Point(-point.Y + center.Y + center.X, -point.X + center.X + center.Y));


            points.Add(new Point(point.X, point.Y));
            points.Add(new Point(-point.X + 2 * center.X, point.Y));
            points.Add(new Point(point.X, -point.Y + 2 * center.Y));
            points.Add(new Point(-point.X + 2 * center.X, -point.Y + 2 * center.Y));

            return points;
        }


        public static List<Point> ReflectPointsOfEllipse(Point point, Point center)
        {
            List<Point> points = new List<Point>();

            points.Add(new Point(point.X, point.Y));
            points.Add(new Point(-point.X + 2 * center.X, point.Y));
            points.Add(new Point(point.X, -point.Y + 2 * center.Y));
            points.Add(new Point(-point.X + 2 * center.X, -point.Y + 2 * center.Y));

            return points;
        }
    }
}
