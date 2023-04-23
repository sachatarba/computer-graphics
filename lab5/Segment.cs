using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Segment : Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public Segment(Point p1, Point p2) : base(p1, p2)
        {
            if (p1.Y < p2.Y)
            {
                Start = p1;
                End = p2;
            }
            else
            {
                Start = p2;
                End = p1;
            }
        }


        int Area(Point a, Point b, Point c)
        {
            return (b.X - a.X) * (c.Y - a.Y) - (b.Y - a.Y) * (c.X - a.X);
        }

        private bool IntersectCheck(int a, int b, int c, int d)
        {
            if (a > b) 
            {
                (a, b) = (b, a);
            };
            if (c > d)
            {
                (c, d) = (d, c);
            }

            return Math.Max(a, c) <= Math.Min(b, d);
        }
        

        private bool Intersect(Point a, Point b, Point c, Point d)
        {
            return IntersectCheck(a.X, b.X, c.X, d.X)
                && IntersectCheck(a.Y, b.Y, c.Y, d.Y)
                && Area(a, b, c) * Area(a, b, d) <= 0
                && Area(c, d, a) * Area(c, d, b) <= 0;
        }

        public bool Intersetcion(Segment other)
        {
            return Intersect(Start, End, other.Start, other.End);
        }


        //public bool AreCrossing(Segment other)
        //{
        //    Point p1 = Start, p2 = End, p3 = other.Start, p4 = other.End;

        //    if (!IntersectCheck(p1.X, p1.Y, p2.X, p2.Y))
        //    {
        //        return false;
        //    }

        //    int v1 = Vector<int>.VectorMult(new Vector<int>(p4.X - p3.X, p4.Y - p3.Y), new Vector<int>(p1.X - p3.X, p1.Y - p3.Y));
        //    int v2 = Vector<int>.VectorMult(new Vector<int>(p4.X - p3.X, p4.Y - p3.Y), new Vector<int>(p2.X - p3.X, p2.Y - p3.Y));
        //    int v3 = Vector<int>.VectorMult(new Vector<int>(p2.X - p1.X, p2.Y - p1.Y), new Vector<int>(p3.X - p1.X, p3.Y - p1.Y));
        //    int v4 = Vector<int>.VectorMult(new Vector<int>(p2.X - p1.X, p2.Y - p1.Y), new Vector<int>(p4.X - p1.X, p4.Y - p1.Y));

        //    if ((v1 * v2) < 0 && (v3 * v4) < 0)
        //    {
        //        return true;
        //    }

        //    return false;
        //}
    }
}
