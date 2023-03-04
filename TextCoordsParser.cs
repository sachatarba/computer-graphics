using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab2
{
    internal class TextCoordsParser
    {
       public static List<(Point, Point)> GetCoordsFromTxt(String filepath)
       {
            try 
            {
                StreamReader sr = new StreamReader(filepath);
                List<(Point, Point)> lines = new List<(Point, Point)>();

                String buff = sr.ReadLine();
                buff= buff.Trim();
                String[] points = buff.Split(';');
                String[] firstPoint = points[0].Split(' ');
                String[] SecondPoint = points[1].Split(' ');
                

                int x, y;
                Point point1 = new Point();
                Point point2 = new Point();

                while ()
                if (int.TryParse(firstPoint[0], out x) && int.TryParse(firstPoint[0], out y))
                {
                    point1.X = x;
                    point1.Y = y;
                }
                else
                {
                    throw new Exception("Невозможно получить координаты точки");
                }

                if (int.TryParse(firstPoint[0], out x) && int.TryParse(firstPoint[0], out y))
                {
                    point2.X = x;
                    point2.Y = y;
                }
                else
                {
                    throw new Exception("Невозможно получить координаты точки");
                }
            }
            catch (Exception ex)
            {
                
            }
       }
    }
}
