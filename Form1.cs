using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<(Point, Point)> lines = TextCoordsParser.GetCoordsFromTxt("C:\\Users\\Lenevo Legion 5\\source\\repos\\CG-Lab2\\Заяц.txt");

            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 5);
            //MessageBox.Show($"{lines.Count}");
            foreach (var line in lines)
            {
                //MessageBox.Show($"{line.Item1.X} {line.Item1.Y} {line.Item2.X} {line.Item2.Y}");
                g.DrawLine(pen, line.Item1, line.Item2);
            }

            pen = new Pen(Color.Black, 3);
            lines = TextCoordsParser.GetCoordsFromTxt("C:\\Users\\Lenevo Legion 5\\source\\repos\\CG-Lab2\\скелет.txt");
            foreach (var line in lines)
            {
                //MessageBox.Show($"{line.Item1.X} {line.Item1.Y} {line.Item2.X} {line.Item2.Y}");
                g.DrawLine(pen, line.Item1, line.Item2);
            }
        }
    }
}
