using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

            List<Segment> edges = PointsProcessor.GetSegments(points);
            List<Point> pointsOfIntersection = new List<Point>();

            int temp = topBorder;
            for (int y = topBorder - 2; y > bottomBorder; --y)
            {
                Segment scanningRow = new Segment(new Point(leftBorder, y), new Point(rightBorder, y));

                foreach (Segment edge in edges)
                {
                    if (scanningRow.Intersetcion(edge))
                    {
                        pointsOfIntersection.Add(scanningRow.PointOfIntersection(edge, y));
                        
                    }
                    try
                    {
                        if (pointsOfIntersection[pointsOfIntersection.Count - 1].Y != y)
                        {
                            MessageBox.Show("eefafe");
                        }

                    }
                    catch
                    {

                    }
                }
            }

            Pen pen = new Pen(color);
            List<Point> sortedPoints = pointsOfIntersection.OrderBy(point => point.X).ToList();
            int currentIntersection = 0;

            for (int y = topBorder - 2; y > bottomBorder; --y)
            {
                //currentIntersection = 0;
                Segment scanningRow = new Segment(new Point(leftBorder, y), new Point(rightBorder, y));
                bool is_inside = false;

                for (int x = leftBorder; x <= rightBorder; ++x) 
                {
                    if (sortedPoints.Contains(new Point(x, y)))
                    {
                        is_inside = !is_inside;
                    }

                    if (is_inside)
                    {
                        g.DrawRectangle(pen, x, y, 1, 1);
                    }
                }
            }
        }
    }
}
