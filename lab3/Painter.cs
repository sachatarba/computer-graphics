using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Painter
    {
        public delegate void DrawLineFunc(Graphics g, PointF point1, PointF point2, Color color);

        public static void DrawLineLib(Graphics g, PointF point1, PointF point2, Color color)
        {
            Pen pen = new Pen(color);
            g.DrawLine(pen, point1, point2);
        }


        public static void DrawSpectrum(Graphics g, DrawLineFunc drawLiner, PointF pointC, float lenght,  float angle, Color color)
        {
            PointF end = new PointF(pointC.X + lenght, pointC.Y);
            PointF rotated;
            
            for (float i = 0; i < 360; i += angle)
            {
                rotated = Geometry.TurnPoint(pointC, end, i);
                drawLiner(g, pointC, rotated, color);
            }
        }

        public static void DrawScene(Graphics g, List<(PointF, PointF, Color, DrawLineFunc)> lines, 
            List<(PointF, float, float, Color, DrawLineFunc)> spectrums, Color backColor)
        {

            foreach (var line in lines)
            {
                line.Item4(g, line.Item1, line.Item2, line.Item3);
            }

            foreach (var spectrum in spectrums)
            {
                DrawSpectrum(g, spectrum.Item5, spectrum.Item1, spectrum.Item2, spectrum.Item3, spectrum.Item4);
            }
        }

        public static void DrawBrezenhemFloat(Graphics g, PointF point1, PointF point2, Color color)
        {
            var listPoints = Brezenhem.BrezenhemFloat(point1.X, point1.Y, point2.X, point2.Y, color, out int steps);
            foreach (var point in listPoints)
            {
                Pen pen= new Pen(point.Item2);
                g.DrawEllipse(pen, point.Item1.X, point.Item1.Y, 1f, 1f);
            }
        }

        public static void DrawBrezenhemInteger(Graphics g, PointF point1, PointF point2, Color color)
        {
            var listPoints = Brezenhem.BrezenhemInteger(Convert.ToInt32(point1.X), Convert.ToInt32(point1.Y)
                , Convert.ToInt32(point2.X), Convert.ToInt32(point2.Y)
                , color, out int steps);

            foreach (var point in listPoints)
            {
                Pen pen = new Pen(point.Item2);
                g.DrawEllipse(pen, point.Item1.X, point.Item1.Y, 1, 1);
            }
        }


        public static void DrawBrezenhemSmooth(Graphics g, PointF point1, PointF point2, Color color)
        {
            var listPoints = Brezenhem.BrezenhemSmooth(point1.X, point1.Y
                , point2.X, point2.Y
                , color, out int steps);

            foreach (var point in listPoints)
            {
                Pen pen = new Pen(point.Item2);
                g.DrawEllipse(pen, point.Item1.X, point.Item1.Y, 1, 1);
            }
        }

        public static void DrawDda(Graphics g, PointF point1, PointF point2, Color color)
        {
            var listPoints = DDA.Dda(Convert.ToInt32(point1.X), Convert.ToInt32(point1.Y)
                , Convert.ToInt32(point2.X), Convert.ToInt32(point2.Y)
                , color, out int steps);

            foreach (var point in listPoints)
            {
                Pen pen = new Pen(point.Item2);
                g.DrawEllipse(pen, point.Item1.X, point.Item1.Y, 1, 1);
            }
        }


        public static void DrawVu(Graphics g, PointF point1, PointF point2, Color color)
        {
            var listPoints = VU.Vu(point1.X, point1.Y
                ,point2.X, point2.Y
                , color, out int steps);

            foreach (var point in listPoints)
            {
                Pen pen = new Pen(point.Item2);
                g.DrawEllipse(pen, point.Item1.X, point.Item1.Y, 1, 1);
            }
        }
    }
}
