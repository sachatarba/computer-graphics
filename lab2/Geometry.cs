using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab2.lab2
{
    internal class Geometry
    {
        public static void RotateLines(List<(Point, Point)> lines, int angle)
        {
            double angleRadians = angle * Math.PI / 180;
            var (SinA, CosA) = (Math.Sin(angleRadians), Math.Cos(angleRadians));

            for (int i = 0; i < lines.Count; ++i)
            {
                int newX1 = Convert.ToInt32(CosA * lines[i].Item1.X - SinA * lines[i].Item1.Y);
                int newY1 = Convert.ToInt32(SinA * lines[i].Item1.X + CosA * lines[i].Item1.Y);
                int newX2 = Convert.ToInt32(CosA * lines[i].Item2.X - SinA * lines[i].Item2.Y);
                int newY2 = Convert.ToInt32(SinA * lines[i].Item2.X + CosA * lines[i].Item2.Y);

                lines[i] = (new Point(newX1, newY1), new Point(newX2, newY2));
            }
        }
    }
}
