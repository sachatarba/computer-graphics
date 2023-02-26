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
        public static void DrawPoint(Graphics g, Point point, Color color)
        {
            SolidBrush toDrawPoint = new(color);
            g.FillEllipse(toDrawPoint, point.X, point.Y, 5, 5);
        }

        public static void DrawPoints(Graphics g, List<Point> points, Color color)
        {
            foreach (Point point in points)
            {
                DrawPoint(g, point, color);
            }
        }

        public static void DrawCirlce(Graphics g, Circle circle, Color color) 
        {
            Pen pen = new(color);
            g.DrawEllipse(pen, circle.Center.X - circle.Radius + 2, circle.Center.Y - circle.Radius + 2,
              circle.Radius * 2, circle.Radius * 2);
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
