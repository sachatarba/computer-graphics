using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class VU
    {
        public static List<(PointF, Color)> Vu(float x1, float y1, float x2, float y2, Color color, out int steps, bool stepmode=false)
        {
            List<(PointF, Color)> pointsList= new List<(PointF, Color)> ();
            steps= 0;

            if (x1 == x2 && y1 == y2)
            {
                return pointsList;
            }

            var (red, green, blue) = (color.R, color.G, color.B);
            bool exchange = Math.Abs(y2 - y1) > Math.Abs(x2 - x1);

            if (exchange)
            {
                (x1, y1) = (y1, x1);
                (x2, y2) = (y2, x2);
            }

            if (x1 > x2)
            {
                (x1, x2) = (x2, x1);
                (y1, y2) = (y2, y1);
            }

            float dx = x2 - x1;
            float dy = y2 - y1;
            float tg = 0;
            
            if (dx == 0)
            {
                tg = 1;
            }
            else
            {
                tg = dy / dx;
            }

            int xend = Convert.ToInt32(x1);
            float yend = y1 + tg * (xend - x1);
            int xpx1 = xend;
            float y = yend + tg;

            int xpx2 = Convert.ToInt32(x2 + 0.5f);
            
            if (exchange)
            {
                for (int x = xpx1; x < xpx2; ++x) 
                {
                    int opacity = Convert.ToInt32(255 - Convert.ToInt32(Math.Abs(y - Math.Truncate(y)) * 255));
                    if (opacity > 255)
                    {
                        opacity = 255;
                    }
                    if (opacity == 0)
                    {
                        opacity = 255;
                    }
                    pointsList.Add((new PointF(Convert.ToInt32(y), x + 1), Color.FromArgb(opacity, red, green, blue)));

                    if (x < Convert.ToInt32(x2) && Convert.ToInt32(y) != Convert.ToInt32(y + tg))
                    {
                        ++steps;
                    }

                    y += tg;

                }
            }
            else
            {
                for (int x = xpx1; x < xpx2; ++x)
                {
                    int opacity = Convert.ToInt32(255 - Convert.ToInt32(Math.Abs(y - Math.Truncate(y)) * 255));
                    if (opacity > 255)
                    {
                        opacity = 255;
                    }
                    if (opacity == 0)
                    {
                        opacity = 255;
                    }
                    pointsList.Add((new PointF(x + 1, Convert.ToInt32(y)), Color.FromArgb(opacity, red, green, blue)));

                    if (x < Convert.ToInt32(x2) && Convert.ToInt32(y) != Convert.ToInt32(y + tg))
                    {
                        ++steps;
                    }

                    y += tg;

                }
            }


            return pointsList;
        }
    }
}
