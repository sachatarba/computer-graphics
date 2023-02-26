namespace WinFormsApp3
{
    internal class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }

        public List<Point>? Points { get; set; }

        public Color CircleColor { get; set; }

        public Circle(Point center, int radius, Color color)
        {
            Center = center;
            Radius = radius;
            CircleColor = color;
        }

        public Circle(Point center, int radius) :
            this(center, radius, Color.Red) { }

        public Circle(Point point1, Point point2, Point point3, Color color) 
        {
            List<Point> points = ProcessPoints(point1, point2, point3);

            double k1 = (points[1].Y - points[0].Y) / Convert.ToDouble(points[1].X - points[0].X);
            double k2 = (points[2].Y - points[1].Y) / Convert.ToDouble(points[2].X - points[1].X);

            if (Math.Abs(k1 - k2) < double.Epsilon)
            {
                throw new Exception("Невозможно определить круг по данным точкам");
            }

            double xc = (k1 * k2 * (points[0].Y - points[2].Y) + k2 *
                (points[0].X + points[1].X) - k1 * (points[1].X + points[2].X)) / (2 * (k2 - k1));
            double yc = -1 / k1 * (xc - (points[0].X + points[1].X) / 2d) + (points[0].Y + points[1].Y) / 2d;
           
            Radius = Convert.ToInt32(Math.Sqrt(Math.Pow(xc - points[0].X, 2) + Math.Pow(yc - points[0].Y, 2)));
            Center = new(Convert.ToInt32(xc), Convert.ToInt32(yc));
            Points = points;
            CircleColor = color;
        }

        public Circle(Point point1, Point point2, Point point3) : 
            this(point1, point2, point3, Color.Red) { }

        // Функция переставляет точки так, чтобы ни одна из соседних точек в порядке
        // следования не имела совпадений значений по иксу
        private static List<Point> ProcessPoints(Point point1, Point point2, Point point3)
        {
            List<Point> points = new()
            {
                point1,
                point2,
                point3
            };
            
            points = points.OrderBy(point => point.X).ToList();
            (points[0], points[1]) = (points[1], points[0]);
            (points[1], points[2]) = (points[2], points[1]);

            return points;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new(CircleColor);
            g.DrawEllipse(pen, Center.X - Radius + 2, Center.Y - Radius + 2,
              Radius * 2, Radius * 2);
        }
    }
}
