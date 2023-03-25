using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal class ColoredPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Color PointColor { get; set; }

        public ColoredPoint(int x, int y, Color color) 
        {
            X = x;
            Y = y;
            PointColor = color;
        }

        public ColoredPoint(Point point, Color color) 
        {
            X = point.X;
            Y = point.Y;
            PointColor = color;
        }

        public void Draw(Graphics g) 
        {
            SolidBrush brush = new(PointColor);
            g.FillEllipse(brush, X, Y, 5, 5);
        }
    }
}
