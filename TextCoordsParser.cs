using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Lab2
{
    internal class TextCoordsParser
    {
       public static List<(Point, Point)> GetCoordsFromTxt(String filepath)
       {
            List<(Point, Point)> lines = new List<(Point, Point)>();
            
            //try 
            //{
                StreamReader sr = new StreamReader(filepath);

                String buff = sr.ReadLine();
                while (buff != null)
                {
                    buff = buff.Trim();
                    String[] points = buff.Split(';');
                    String[] firstPoint = points[0].Trim().Split(' ');
                    String[] secondPoint = points[1].Trim().Split(' ');
                //MessageBox.Show($"point {points[1]} x{secondPoint[0]} y{secondPoint[1]}");

                    Point point1 = new Point();
                    Point point2 = new Point();

                    if (int.TryParse(firstPoint[0].Trim(), out int x) && int.TryParse(firstPoint[1].Trim(), out int y))
                    {
                        point1.X = x;
                        point1.Y = y;
                    }
                    else
                    {
                        throw new Exception("Невозможно получить координаты точки");
                    }

                    if (int.TryParse(secondPoint[0].Trim(), out x) && int.TryParse(secondPoint[1].Trim(), out y))
                    {
                        point2.X = x;
                        point2.Y = y;
                    }
                    else
                    {
                        throw new Exception("Невозможно получить координаты точки");
                    }

                    lines.Add((point1, point2));
                    buff = sr.ReadLine();
                }

                sr.Close();
            //}
            //catch (Exception ex)
            //{
                
            //}

            return lines;
       }
    }
}
