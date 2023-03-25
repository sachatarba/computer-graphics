using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal class ListViewParser
    {
        public static Point ToPoint(ListViewItem item)
        {
            string[] coords = item.Text.Trim().Split(';');
            float x = float.Parse(coords[0]);
            float y = float.Parse(coords[1]);
            return new(Convert.ToInt32(x), Convert.ToInt32(y));
        }
        public static List<Point> CoordsParser(ListView listView)
        {
            List<Point> points = new();
            foreach (ListViewItem item in listView.Items)
            {
                points.Add(ToPoint(item));
            }

            return points;
        }

        public static List<Point> ChooseActivatedOrCheckedPoints(ListView listView)
        {
            List<Point> points = new();
            
            foreach (ListViewItem item in listView.Items) 
            {
                if (item.Checked || item.Selected) 
                {
                    points.Add(ToPoint(item));
                }
            }

            return points;
        }
    }
}
