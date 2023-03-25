using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal class Minimizer
    {
        public static double CalcDistance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
        }
        public static Point FindNearestPoint(List<Point> points)
        {
            if (points.Count == 0)
                throw new Exception("Пустой список точек");
            double minDistances = double.MaxValue;
            double distances;
            Point nearestPoint = new();

            foreach (Point point1 in points)
            {
                distances = 0;
                foreach (Point point2 in points)
                {
                    distances += CalcDistance(point1, point2);
                }

                if (distances < minDistances) 
                {
                    minDistances = distances;
                    nearestPoint = point1;
                }
            }

            return nearestPoint;
        }

        public static Circle FindMinRadius(List<Point> pointsToChoose, Point pointObligatory) 
        {
            if (pointsToChoose.Count == 0)
                throw new Exception("Пустой список точек");

            pointsToChoose.Remove(pointObligatory);
            Circle circleToRet = new(new Point(0, 0), int.MaxValue);

            for (int i = 0; i < pointsToChoose.Count; ++i)
            {
                for (int j = i + 1; j < pointsToChoose.Count; ++j)
                {
                    try
                    {
                        Circle temp = new(pointObligatory, pointsToChoose[i], pointsToChoose[j]);
                        if (temp.Radius < circleToRet.Radius)
                        {
                            circleToRet = temp;
                        }
                    }
                    catch { }
                }
            }

            if (circleToRet.Radius == int.MaxValue)
                throw new Exception("Круг не определен по данным точкам");

            return circleToRet;
        } 
    }
}
