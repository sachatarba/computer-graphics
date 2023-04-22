namespace lab5
{
    internal class Vector<T>
    {
        public Vector(T x, T y)
        {
            X = x;
            Y = y;
        }

        public T X { get; set; }
        public T Y { get; set; }
    }
}