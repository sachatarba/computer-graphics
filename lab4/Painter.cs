using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Painter
    {
        public delegate void DrawEllipseFunc(Graphics g, PointF center, int width, int height, Color color);

        public static void DrawEllipseLib(Graphics g, PointF center, int width, int height, Color color)
        {
            Pen pen = new Pen(color);
            //Pen pen = new Pen(Color.Black);
            g.DrawEllipse(pen, center.X - width, center.Y - height, width * 2, height * 2);
        }

        public static void DrawScene(Graphics g, List<IDrawable> drawablesObjects)
        {
            foreach (var drawable in drawablesObjects)
            {
                drawable.DrawObject(g);
            } 
        }
    }
}
