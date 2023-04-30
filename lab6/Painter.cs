using lab3;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    internal class Painter
    {
        public static List<Point> DrawLines(Graphics g, List<Point> points, Color color)
        {   
            List<Point> borderPoints = new List<Point>();

            if (points.Count >= 2)
            {
                //g.DrawLines(pen, points.ToArray());
                for (int i = 0; i < points.Count - 1; ++i)
                {
                    borderPoints.AddRange(DrawDDA(g, points[i], points[i + 1], color));
                }
            }

            return borderPoints;
        }

        public static void DrawBrezenhemInteger(Graphics g, Point point1, Point point2, Color color)
        {
            var listPoints = Brezenhem.BrezenhemInteger(point1.X, point1.Y, point2.X, point2.Y, color, out int steps);

            foreach (var point in listPoints)
            {
                Pen pen = new Pen(point.Item2);
                g.DrawEllipse(pen, point.Item1.X, point.Item1.Y, 1, 1);
            }
        }

        public static List<Point> DrawDDA(Graphics g, Point point1, Point point2, Color color)
        {
            var listPoints = DDA.Dda(point1.X, point1.Y, point2.X, point2.Y, color, out int steps);

            foreach (var point in listPoints)
            {
                Pen pen = new Pen(point.Item2);
                g.DrawEllipse(pen, point.Item1.X, point.Item1.Y, 1, 1);
            }

            return listPoints.ConvertAll(x => x.Item1);
        }

        public static void DrawBrezenhemFloat(Graphics g, PointF point1, PointF point2, Color color)
        {
            var listPoints = Brezenhem.BrezenhemFloat(Convert.ToInt32(point1.X), Convert.ToInt32(point1.Y)
                , Convert.ToInt32(point2.X), Convert.ToInt32(point2.Y)
                , color, out int steps);

            MessageBox.Show($"{listPoints.Count}");


            foreach (var point in listPoints)
            {
                Pen pen = new Pen(point.Item2);
                g.DrawEllipse(pen, point.Item1.X, point.Item1.Y, 1, 1);
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

        public static void FillFIgureBySeedPoint(Graphics g, Point seed, List<Point> borderPoints, List<Point> filledPoints, Color color)
        {
            Stack<Point> stack = new Stack<Point>();
            stack.Push(seed);

            Pen pen = new Pen(color);

            while (stack.Count != 0)
            {
                Point pixel = stack.Pop();
                int x = pixel.X, y = pixel.Y;

                filledPoints.Add(new Point(x, y));
                g.DrawRectangle(pen, x, y, 1, 1);
                int tx = x, ty = y;
                ++x;

                while (!filledPoints.Contains(new Point(x, y)) &&
                    !borderPoints.Contains(new Point(x, y)))
                {
                    g.DrawRectangle(pen, x, y, 1, 1);
                    filledPoints.Add(new Point(x, y));
                    ++x;
                }

                int rightBorder = x - 1;

                x = tx - 1;

                while (!filledPoints.Contains(new Point(x, y)) &&
                    !borderPoints.Contains(new Point(x, y)))
                {
                    g.DrawRectangle(pen, x, y, 1, 1);
                    filledPoints.Add(new Point(x, y));
                    --x;
                }

                int leftBorder = x + 1;

                y = ty + 1;
                x = leftBorder;

                while (x <= rightBorder)
                {
                    bool flag = false;

                    while (!filledPoints.Contains(new Point(x, y)) &&
                    !borderPoints.Contains(new Point(x, y)) && x <= rightBorder)
                    {
                        flag = true;
                        ++x;
                    }

                    if (flag)
                    {
                        if (x == rightBorder && !filledPoints.Contains(new Point(x, y)) &&
                    !borderPoints.Contains(new Point(x, y)))
                        {
                            stack.Push(new Point(x, y));
                        }
                        else
                        {
                            stack.Push(new Point(x - 1, y));
                        }

                        flag = false;
                    }

                    int startX = x;

                    while ((filledPoints.Contains(new Point(x, y)) ||
                    borderPoints.Contains(new Point(x, y))) && x < rightBorder)
                    {
                        ++x;
                    }

                    if (x == startX)
                    {
                        ++x;
                    }
                }

                x = leftBorder; y = ty - 1;

                while (x <= rightBorder)
                {
                    bool flag = false;

                    while (!filledPoints.Contains(new Point(x, y)) &&
                    !borderPoints.Contains(new Point(x, y)) && x <= rightBorder)
                    {
                        flag = true;
                        ++x;
                    }

                    if (flag)
                    {
                        if (x == rightBorder && !filledPoints.Contains(new Point(x, y)) &&
                    !borderPoints.Contains(new Point(x, y)))
                        {
                            stack.Push(new Point(x, y));
                        }
                        else
                        {
                            stack.Push(new Point(x - 1, y));
                        }

                        flag = false;
                    }

                    int startX = x;

                    while ((filledPoints.Contains(new Point(x, y)) ||
                    borderPoints.Contains(new Point(x, y))) && x < rightBorder)
                    {
                        ++x;
                    }

                    if (x == startX)
                    {
                        ++x;
                    }

                }


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
