using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        public static void DrawPoints(Graphics g, List<Point> points, Color color)
        {
            Pen pen = new Pen(color);

            foreach (Point point in points)
            {
                g.DrawRectangle(pen, point.X, point.Y, 3, 3);
            }
        }

        public static void FillFigure(Graphics g, List<List<Point>> figures, Color color)
        {
            int leftBorder = figures[0].Min(p => p.X);
            int rightBorder = figures[0].Max(p => p.X);
            int topBorder = figures[0].Max(p => p.Y);
            int bottomBorder = figures[0].Min(p => p.Y);

            foreach (List<Point> figure in figures) {
                leftBorder = Math.Min(leftBorder, figure.Min(p => p.X));
                rightBorder = Math.Max(rightBorder, figure.Max(p => p.X));
                topBorder = Math.Max(topBorder, figure.Max(p => p.Y));
                bottomBorder = Math.Min(bottomBorder, figure.Min(p => p.Y));
            }

            List<Segment> edges = new List<Segment>();
            foreach (List<Point> figure in figures)
            {
                edges.AddRange(PointsProcessor.GetSegments(figure));
            }
            List<Point> pointsOfIntersection = new List<Point>();

            List<Point> points = new List<Point>();

            foreach (List<Point> figure in figures)
            {
                points.AddRange(new List<Point>(figure));
            }

            int temp = topBorder;
            for (int y = topBorder - 2; y > bottomBorder; --y)
            {
                Segment scanningRow = new Segment(new Point(leftBorder, y), new Point(rightBorder, y));

                foreach (Segment edge in edges)
                {
                    if (scanningRow.Start.Y <= edge.End.Y && scanningRow.Start.Y >= edge.Start.Y)
                    {
                        try
                        {
                            Point intersection = scanningRow.PointOfIntersection(edge, y);
                            pointsOfIntersection.Add(intersection);
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
            }

            Pen pen = new Pen(color);
            List<Point> sortedPoints = pointsOfIntersection.OrderBy(point => point.Y).ToList();

            StreamWriter file = new StreamWriter("C:\\Users\\Lenevo Legion 5\\source\\repos\\sachatarba\\computer-graphics\\lab5\\log.txt");
            foreach (Point point in sortedPoints)
            {
                file.WriteLine($"{point.X} {point.Y}");
            }
            file.Close();

            //Pen backPen = new Pen(Color.White); 
            for (int y = topBorder - 2; y > bottomBorder; --y)
            {
                //currentIntersection = 0;
                Segment scanningRow = new Segment(new Point(leftBorder, y), new Point(rightBorder, y));
                bool is_inside = false;

                if (points.Count(p => p.Y == y) == 0)
                {
                    for (int x = leftBorder; x <= rightBorder; ++x)
                    {
                        Point curPoint = new Point(x, y);
                        if (sortedPoints.Contains(curPoint) && sortedPoints.Count(p => p == curPoint) % 2 != 0)
                        {
                            is_inside = !is_inside;
                        }
                        else if (points.Contains(curPoint))
                        {
                            is_inside = !is_inside;
                        }

                        if (is_inside)
                        {
                            //g.Clear(Color.Black);
                            g.DrawRectangle(pen, x, y, 1, 1);
                        }
                        //else
                        //{
                        //    g.DrawRectangle(backPen, x, y, 1, 1);
                        //}
                    }
                }
            }
        }
    }
}
