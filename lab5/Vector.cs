namespace lab5
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