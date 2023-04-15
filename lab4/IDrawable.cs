using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal interface IDrawable
    {
        Color ObjectColor { get; set; }
        void DrawObject(Graphics g);

        PointF Center { get; set; }

        int Height { get; set; }
        int Width { get; set; }

        Painter.DrawEllipseFunc DrawFunction { get; set; }
    }
}
