using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    internal class ColoredCircle : IDrawable
    {
        public ColoredCircle(PointF center, int radius, Color color, Painter.DrawEllipseFunc func) 
        {
            Center = center;
            Height = radius;
            Width = radius;
            DrawFunction = func;
            ObjectColor = color;
        }

        public Color ObjectColor { get; set; }
        public PointF Center { get; set; }
        public int Height { get; set; }
        public int Width { get; set ; }

        public Painter.DrawEllipseFunc DrawFunction { get; set; }

        public void DrawObject(Graphics g)
        {
            DrawFunction(g, Center, Width, Height, ObjectColor);
        }
    }
}
