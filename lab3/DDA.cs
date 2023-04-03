using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    internal class DDA
    {
        public static List<(Point, Color)> Dda(float x1, float y1, float x2, float y2, Color color, out int steps, bool stepmode = false)
        {
            List<(Point, Color)> pointList = new List<(Point, Color)> ();
            steps = 0;
            
            if (x1 == x2 && y1 == y2) 
            {
                pointList.Add((new Point(Convert.ToInt32(x1), Convert.ToInt32(y1)), color));
                return pointList;
            }

            float dx = Math.Abs(x1 - x2);
            float dy = Math.Abs(y1 - y2);

            float length;
            
            if (dx >= dy)
            {
                length = dx;
            }
            else
            {
                length = dy;
            }

            dx = (x2 - x1) / length;
            dy = (y2 - y1) / length;

            float x = x1;
            float y = y1;

            for (int i = 1; i < Convert.ToInt32(length) + 1; ++i)
            {
                if (!stepmode)
                {
                    pointList.Add((new Point(Convert.ToInt32(x), Convert.ToInt32(y)), color));
                }
                else if (Convert.ToInt32(x + dx) != Convert.ToInt32(x) && Convert.ToInt32(y + dy) != Math.Round(y))
                {
                    steps++;
                }

                x += dx;
                y += dy;
            }

            return pointList;
        }
    }
}
