using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static void FillFigure(Graphics g, List<Point> points, Color color)
        {
            int leftBorder = points.Min(p => p.X);
            int rightBorder = points.Max(p => p.X);
            int topBorder = points.Max(p => p.Y);
            int bottomBorder = points.Min(p => p.Y);

            List<Line> edges = PointsProcessor.GetLines(points);
            List<Point> pointsOfIntersection = new List<Point>();

            for (int y = topBorder; y >= bottomBorder; --y)
            {
                Line scanningRow = new Line(new Point(leftBorder, y), new Point(rightBorder, y));

                foreach (Line edge in edges)
                {
                    if (!scanningRow.AreParallel(edge))
                    {
                        pointsOfIntersection.Add(scanningRow.PointOfIntersection(edge));
                    }
                }
            }

            Pen pen = new Pen(color);

            for (int y = topBorder - 1; y > bottomBorder; --y)
            {
                Line scanningRow = new Line(new Point(leftBorder, y), new Point(rightBorder, y));
                bool is_inside = false;

                for (int x = leftBorder; x <= rightBorder; ++x) 
                {
                    if (pointsOfIntersection.Contains(new Point(x, y)))
                    {
                        is_inside = !is_inside;
                    }

                    if (is_inside)
                    {
                        g.DrawEllipse(pen, x, y, 1, 1);
                    }
                }
            }
        }
    }
}
