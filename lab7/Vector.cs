using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Vector<T>
    {
        public Vector(T x, T y)
        {
            X = x;
            Y = y;
        }

        public static int VectorMult(Vector<int> a, Vector<int> b)
        {
            return a.X * b.Y - b.X * a.Y;
        }

        public T X { get; set; }
        public T Y { get; set; }
    }
}
