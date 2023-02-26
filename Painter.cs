using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal partial class Painter
    {
        public static void DrawPoint(Graphics g, Point point, Color color, int diffx = 0, int diffy = 0, double scale = 1)
        {
            SolidBrush toDrawPoint = new(color);
            g.FillEllipse(toDrawPoint, Convert.ToSingle(point.X * scale + diffx), Convert.ToSingle(point.Y * scale + diffy), 5, 5);
        }

        public static void DrawPoints(Graphics g, List<Point> points, Color color, int diffx = 0, int diffy = 0, double scale = 1)
        {
            foreach (Point point in points)
            {
                DrawPoint(g, point, color, diffx, diffy, scale);
            }
        }

        public static void DrawCirlce(Graphics g, Circle circle, Color color, int diffx = 0, int diffy = 0, double scale = 1) 
        {
            Pen pen = new(color);
            g.DrawEllipse(pen, Convert.ToSingle((circle.Center.X - circle.Radius + 2) * scale + diffx),
                Convert.ToSingle((circle.Center.Y - circle.Radius + 2) * scale + diffy),
              Convert.ToSingle(circle.Radius * 2 * scale), Convert.ToSingle(circle.Radius * 2 * scale));
        }

        public static void HighlightPoints(Graphics g, List<Point> points, int radius = 10)
        {
            foreach (Point point in points)
            {
                //Painter.DrawPoint(g, point, Color.DarkGreen);
                Painter.DrawCirlce(g, new Circle(point, radius), Color.DarkGreen);
            }
        }
    }
}
