using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Geometry
    {

        public static float ToRadians(float angleDegree)
        {
            return Convert.ToSingle(angleDegree * Math.PI / 180);
        }
        public static PointF TurnPoint(PointF centerOfRotation, PointF toRotate, float angle)
        {
            float cosA = Convert.ToSingle(Math.Cos(ToRadians(angle)));
            float sinA = Convert.ToSingle(Math.Sin(ToRadians(angle)));

            float newX = centerOfRotation.X + (toRotate.X - centerOfRotation.X) * cosA - (toRotate.Y - centerOfRotation.Y) * sinA;
            float newY = centerOfRotation.Y + (toRotate.X - centerOfRotation.X) * sinA + (toRotate.Y - centerOfRotation.Y) * cosA;

            return new PointF(newX, newY);
        }

    }
}
