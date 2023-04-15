using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class ColoredEllipse : IDrawable
    {
        public ColoredEllipse(PointF center, int height, int width, Color color, Painter.DrawEllipseFunc func) {
            Center = center;
            Height = height;
            Width = width;
            DrawFunction = func;
            ObjectColor = color;
        }
        public Color ObjectColor { get; set; }
        public PointF Center { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Painter.DrawEllipseFunc DrawFunction { get; set; }

        public void DrawObject(Graphics g)
        {
            DrawFunction(g, Center, Width, Height, ObjectColor);
        }
    }
}
