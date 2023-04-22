using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Line
    {
        int A { get; set; }
        int B { get; set; }
        int C { get; set; }

        public bool AreParallel(Line otherLine)
        {
            if (A == otherLine.A && B == otherLine.B)
            {
                return true;
            }

            return false;
        }

        public Line(Point p1, Point p2) 
        {
            A = p2.Y - p1.Y;
            B = p1.X - p2.X;
            C = -p1.X * (p2.Y - p1.Y) + p1.Y * (p2.X - p1.X);
        }

        public Point PointOfIntersection(Line otherLine)
        {
            if (AreParallel(otherLine))
            {
                throw new ArgumentException("Lines are parallel");
            }

            double d = Convert.ToDouble(A * otherLine.B - B * otherLine.A);
            double dx = Convert.ToDouble(-C * otherLine.B + B * otherLine.C);
            double dy = Convert.ToDouble(-A * otherLine.C + C * otherLine.A);

            Point pt = new Point(Convert.ToInt32(dx / d), Convert.ToInt32(dy / d));

            return pt;
        }
    }
}
