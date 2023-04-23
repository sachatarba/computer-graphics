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
                    //if (scanningRow.Intersetcion(edge))
                    if (scanningRow.Start.Y <= edge.End.Y && scanningRow.Start.Y >= edge.Start.Y)
                    {
                        Point intersection = scanningRow.PointOfIntersection(edge, y);
                        //if (!pointsOfIntersection.Contains(intersection) && !points.Contains(intersection))
                            pointsOfIntersection.Add(intersection);
                        
                    }
                    //else
                    //{
                    //    MessageBox.Show($"{edge.Start.X} {edge.Start.Y} {edge.End.X} {edge.End.Y};" +
                    //        $"{scaningRow.Start.Y}");
                    //}
                    try
                    {
                        //if (pointsOfIntersection[pointsOfIntersection.Count - 1].Y != y)
                        //{
                        //    MessageBox.Show("eefafe");
                        //}

                    }
                    catch
                    {

                    }
                }
            }

            Pen pen = new Pen(color);
            List<Point> sortedPoints = pointsOfIntersection.OrderBy(point => point.Y).ToList();

            StreamWriter file = new StreamWriter("C:\\Users\\Lenevo Legion 5\\source\\repos\\sachatarba\\computer-graphics\\lab5\\log.txt");
            foreach (Point point in sortedPoints)
            {
                //MessageBox.Show($"{ point.X} {point.Y}");
                file.WriteLine($"{point.X} {point.Y}");
            }
            file.Close();
            int currentIntersection = 0;
            Pen backPen = new Pen(Color.White); 

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
                            //if (is_inside)
                            //{

                            //}
                            is_inside = !is_inside;
                        }
                        else if (points.Contains(curPoint))
                        {
                            is_inside = !is_inside;
                        }

                        if (is_inside)
                        {
                            g.DrawRectangle(pen, x, y, 1, 1);
                        }
                        else
                        {
                            g.DrawRectangle(backPen, x, y, 1, 1);
                        }
                    }
                }
            }
        }
    }
}
