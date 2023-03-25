using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Lab2.lab2
{
    internal class Painter
    {
        public static void DrawLines(Graphics g, List<(Point2f, Point2f)> lines, Color backColor, float width = 5)
        {
            Pen pen = new Pen(backColor, width);

            foreach (var line in lines)
            {
                g.DrawLine(pen, line.Item1.X, line.Item1.Y, line.Item2.X, line.Item2.Y);
            }
        }
    }
}
