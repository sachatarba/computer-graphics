using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal class Scene
    {
        private readonly List<ColoredPoint> coloredPoints;

        private readonly List<Circle> coloredCircles;

        public Scene() 
        {
            coloredPoints = new List<ColoredPoint>();
            coloredCircles = new List<Circle>();
        }

        public void AddColoredPoint(ColoredPoint point)
        {
            coloredPoints.Add(point);
        }

        public void AddCircle(Circle circle) 
        {
            coloredCircles.Add(circle);
        }

        public void Clear()
        {
            coloredPoints.Clear();
            coloredCircles.Clear();
        }

        public void Draw(Graphics g, Color backColor)
        {
            g.Clear(backColor);

            foreach (ColoredPoint point in coloredPoints)
            {
                point.Draw(g);
            }

            foreach (Circle circle in coloredCircles)
            {
                circle.Draw(g);
            }
        }
    }
}
