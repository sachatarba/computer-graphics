using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    internal class Brezenhem
    {
        public static List<(PointF, Color)> BrezenhemFloat(float x1, float y1, float x2, float y2, Color color, out int steps, bool stepmode = false)
        {
            var pointsList = new List<(PointF, Color)>();
            steps = 0;
            
            if (x1 == x2 && y1 == y2)
            {
                pointsList.Add((new PointF(x1, y1), color));
                return pointsList;
            }

            float dx = x2 - x1;
            float dy = y2 - y1;

            int sx = Utils.Sign(dx);
            int sy = Utils.Sign(dy);

            dy = Math.Abs(dy);
            dx = Math.Abs(dx);
            int exchange;

            if (dy > dx)
            {
                (dx, dy) = (dy, dx);
                exchange = 1;
            }
            else
            {
                exchange = 0;
            }

            float tg = dy / dx;
            float e = tg - 0.5f;
            float x = x1;
            float y = y1;

            float xb = x1;
            float yb = y1;

            while (x != x2 || y != y2)
            {

                if (!stepmode)
                {
                    pointsList.Add((new PointF(x, y), color));
                }

                if (e >= 0)
                {
                    if (exchange == 1)
                    {
                        x += sx;
                    }
                    else
                    {
                        y += sy;
                    }
                    
                    e -= 1;
                }
                if (e <= 0)
                {
                    if (exchange == 0)
                    {
                        x += sx;
                    }
                    else
                    {
                        y += sy;
                    }
                    e += tg;
                }

                if (stepmode)
                {
                    if (xb != x && yb != y)
                    {
                        steps += 1;
                    }
                    
                    xb = x;
                    yb = y;
                }


                if (x2 < 0 && x < x2)
                {
                    break;
                }
                else if (x2 >= 0 && x > x2)
                {
                    break;
                }
                else if (y2 < 0 && y < y2)
                {
                    break;
                }
                else if (y2 >= 0 && y > y2)
                {
                    break;
                }
            }

            
            return pointsList;
        }

        public static List<(Point, Color)> BrezenhemInteger(int x1, int y1, int x2, int y2, Color color, out int steps, bool stepmode = false)
        {
            //MessageBox.Show($"{x2} {y2}");
            var pointsList = new List<(Point, Color)>();
            steps = 0;

            if (x1 == x2 && y1 == y2)
            {
                pointsList.Add((new Point(x1, y1), color));
                return pointsList;
            }

            int dx = x2 - x1;
            int dy = y2 - y1;

            int sx = Utils.Sign(dx);
            int sy = Utils.Sign(dy);

            dy = Math.Abs(dy);
            dx = Math.Abs(dx);
            int exchange;

            if (dy > dx)
            {
                (dx, dy) = (dy, dx);
                exchange = 1;
            }
            else
            {
                exchange = 0;
            }

            int e = 2 * dy - dx;
            int x = x1;
            int y = y1;

            int xb = x1;
            int yb = y1;
            //int counter = 0;

            while (x != x2 || y != y2)
            {

                if (!stepmode)
                {
                    pointsList.Add((new Point(x, y), color));
                }

                if (e >= 0)
                {
                    if (exchange == 1)
                    {
                        x += sx;
                    }
                    else
                    {
                        y += sy;
                    }

                    e -= 2 * dx;
                }
                else if (e <= 0)
                {
                    if (exchange == 0)
                    {
                        x += sx;
                    }
                    else
                    {
                        y += sy;
                    }
                    e += 2 * dy;
                }

                if (stepmode)
                {
                    if (xb != x && yb != y)
                    {
                        steps += 1;
                    }

                    xb = x;
                    yb = y;
                }

                if (x2 < 0 && x < x2)
                {
                    break;
                }
                else if (x2 >= 0 && x > x2)
                {
                    break;
                }
                else if (y2 < 0 && y < y2)
                {
                    break;
                }
                else if (y2 >= 0 && y > y2)
                {
                    break;
                }
            }

            return pointsList;
        }


        public static List<(PointF, Color)> BrezenhemSmooth(float x1, float y1, float x2, float y2, Color color, out int steps, bool stepmode = false)
        {
            var pointsList = new List<(PointF, Color)>();
            
            steps = 0;

            if (x1 == x2 && y1 == y2)
            {
                pointsList.Add((new PointF(x1, y1), color));
                return pointsList;
            }
     
            float dx = x2 - x1;
            float dy = y2 - y1;

            int sx = Utils.Sign(dx);
            int sy = Utils.Sign(dy);

            dy = Math.Abs(dy);
            dx = Math.Abs(dx);
            int exchange;
            //Color lineColor = color.;
            var (red, green, blue) = (color.R, color.G, color.B);

            if (dy > dx)
            {
                (dx, dy) = (dy, dx);
                exchange = 1;
            }
            else
            {
                exchange = 0;
            }

            float tg = dy / dx;
            float e = tg - 0.5f;
            float x = x1;
            float y = y1;

            float xb = x1;
            float yb = y1;

            while (x != x2 || y != y2)
            {

                if (!stepmode)
                {
                    try
                    {
                        pointsList.Add((new PointF(x, y), Color.FromArgb(Convert.ToByte((e + 1.25f) * 255 <= 255 ? (e + 1f) * 255 : 255), red, green, blue)));
                    }
                    catch
                    {
                        MessageBox.Show("bebra");
                    }


                }

                if (e >= 0)
                {
                    if (exchange == 1)
                    {
                        x += sx;
                    }
                    else
                    {
                        y += sy;
                    }

                    e -= 1;
                }
                if (e <= 0)
                {
                    if (exchange == 0)
                    {
                        x += sx;
                    }
                    else
                    {
                        y += sy;
                    }
                    e += tg;
                }

                if (stepmode)
                {
                    if (xb != x && yb != y)
                    {
                        steps += 1;
                    }

                    xb = x;
                    yb = y;
                }

                if (x2 < 0 && x < x2)
                {
                    break;
                }
                else if (x2 >= 0 && x > x2)
                {
                    break;
                }
                else if (y2 < 0 && y < y2)
                {
                    break;
                }
                else if (y2 >= 0 && y > y2)
                {
                    break;
                }

            }

            return pointsList;
        }

    }
}
