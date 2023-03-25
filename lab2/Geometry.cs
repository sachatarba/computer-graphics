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
        public static void RotateLines(List<(Point2f, Point2f)> lines, int angle)
        {
            double angleRadians = angle * Math.PI / 180;
            var (SinA, CosA) = (Math.Sin(angleRadians), Math.Cos(angleRadians));

            for (int i = 0; i < lines.Count; ++i)
            {
                float newX1 = Convert.ToSingle(CosA * lines[i].Item1.X - SinA * lines[i].Item1.Y);
                float newY1 = Convert.ToSingle(SinA * lines[i].Item1.X + CosA * lines[i].Item1.Y);
                float newX2 = Convert.ToSingle(CosA * lines[i].Item2.X - SinA * lines[i].Item2.Y);
                float newY2 = Convert.ToSingle(SinA * lines[i].Item2.X + CosA * lines[i].Item2.Y);

                lines[i] = (new Point2f(newX1, newY1), new Point2f(newX2, newY2));
            }
        }

        public static void MoveLines(List<(Point2f, Point2f)> lines, int dx, int dy)
        {
            for (int i = 0; i < lines.Count; ++i)
            {
                var (newX1, newY1) = (lines[i].Item1.X + dx, lines[i].Item1.Y + dy);
                var (newX2, newY2) = (lines[i].Item2.X + dx, lines[i].Item2.Y + dy);

                lines[i] = (new Point2f(newX1, newY1), new Point2f(newX2, newY2));
            }
        }

        public static void ScaleLines(List<(Point2f, Point2f)> lines, double scaleX, double scaleY)
        {
            for (int i = 0; i < lines.Count; ++i)
            {
                var (newX1, newY1) = (Convert.ToSingle(lines[i].Item1.X * scaleX), Convert.ToSingle(lines[i].Item1.Y * scaleY));
                var (newX2, newY2) = (Convert.ToSingle(lines[i].Item2.X * scaleX), Convert.ToSingle(lines[i].Item2.Y * scaleY));

                lines[i] = (new Point2f(newX1, newY1), new Point2f(newX2, newY2));
            }
        }
    }
}
