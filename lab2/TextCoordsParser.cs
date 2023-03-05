using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Lab2
{
    internal class TextCoordsParser
    {
       public static void GetPoint(String pointCoords, out Point point)
       {
            var (firstCoord, secondCoord)= (pointCoords.Trim().Split(' ')[0], pointCoords.Trim().Split(' ')[1]);
            point = new Point();
            if (int.TryParse(firstCoord, out int x) && int.TryParse(secondCoord, out int y))
            {
                point.X = x;
                point.Y = y;
            }
            else
            {
                MessageBox.Show(
                    "Невозможно получить координаты точек", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }
       public static List<(Point, Point)> GetCoordsFromTxt(String filepath)
       {
            List<(Point, Point)> lines = new List<(Point, Point)>();

            try
            {
                StreamReader sr = new StreamReader(filepath);
                String buff = sr.ReadLine();

                while (buff != null)
                {
                    buff = buff.Trim();
                    String[] points = buff.Split(';');

                    GetPoint(points[0], out Point point1);
                    GetPoint(points[1], out Point point2);

                    lines.Add((point1, point2));
                    buff = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                MessageBox.Show(
                    "Ошибка чтения из файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lines;
       }
    }
}
