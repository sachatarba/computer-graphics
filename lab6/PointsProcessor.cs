using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class PointsProcessor
    {
        public static List<Line> GetLines(List<Point> points)
        {
            List<Line> lines = new List<Line>();

            for (int i = 0; i < points.Count - 1; ++i)
            {
                lines.Add(new Line(points[i], points[i + 1]));   
            }

            return lines;
        }

        public static List<Segment> GetSegments(List<Point> points)
        {
            List<Segment> segments = new List<Segment>();

            for (int i = 0; i < points.Count - 1; ++i)
            {
                segments.Add(new Segment(points[i], points[i + 1]));
            }

            return segments;
        }
    }
}
