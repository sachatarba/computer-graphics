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

        private void Load_Click(object sender, EventArgs e)
        {
            linesCircuit = TextCoordsParser.GetCoordsFromTxt("C:\\Users\\Lenevo Legion 5\\source\\repos\\CG-Lab2\\Заяц.txt");

            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 5);
            //MessageBox.Show($"{lines.Count}");
            foreach (var line in linesCircuit)
            {
                //MessageBox.Show($"{line.Item1.X} {line.Item1.Y} {line.Item2.X} {line.Item2.Y}");
                g.DrawLine(pen, line.Item1, line.Item2);
            }

            pen = new Pen(Color.Black, 3);
            linesSkeleton = TextCoordsParser.GetCoordsFromTxt("C:\\Users\\Lenevo Legion 5\\source\\repos\\CG-Lab2\\скелет.txt");
            foreach (var line in linesSkeleton)
            {
                //MessageBox.Show($"{line.Item1.X} {line.Item1.Y} {line.Item2.X} {line.Item2.Y}");
                g.DrawLine(pen, line.Item1, line.Item2);
            }
        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(rotateX.Text, out int dx))
            {
                MessageBox.Show("Неверный ввод угла поворота", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            double dxRadians = dx * Math.PI / 180;
           
            for (int i = 0; i < linesCircuit.Count; ++i)
            {
                var (newX1, newY1) = (Convert.ToInt32((Math.Cos(dxRadians) * linesCircuit[i].Item1.X - Math.Sin(dxRadians) * linesCircuit[i].Item1.Y)),
                     Convert.ToInt32(Math.Sin(dxRadians) * linesCircuit[i].Item1.X + (Math.Cos(dxRadians) * linesCircuit[i].Item1.Y))); ;
               var (newX2, newY2) = (Convert.ToInt32(Math.Cos(dxRadians) * linesCircuit[i].Item2.X - Math.Sin(dxRadians) * linesCircuit[i].Item2.Y),
                    Convert.ToInt32(Math.Sin(dxRadians) * linesCircuit[i].Item2.X + (Math.Cos(dxRadians) * linesCircuit[i].Item2.Y)));

                linesCircuit[i] = (new Point(newX1, newY1), new Point(newX2, newY2));
            }

            for (int i = 0; i < linesSkeleton.Count; ++i)
            {
                var (newX1, newY1) = (Convert.ToInt32((Math.Cos(dxRadians) * linesSkeleton[i].Item1.X - Math.Sin(dxRadians) * linesSkeleton[i].Item1.Y)),
                     Convert.ToInt32(Math.Sin(dxRadians) * linesSkeleton[i].Item1.X + (Math.Cos(dxRadians) * linesSkeleton[i].Item1.Y))); ;
                var (newX2, newY2) = (Convert.ToInt32(Math.Cos(dxRadians) * linesSkeleton[i].Item2.X - Math.Sin(dxRadians) * linesSkeleton[i].Item2.Y),
                     Convert.ToInt32(Math.Sin(dxRadians) * linesSkeleton[i].Item2.X + (Math.Cos(dxRadians) * linesSkeleton[i].Item2.Y)));

                linesSkeleton[i] = (new Point(newX1, newY1), new Point(newX2, newY2));
            }


            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 5);
            //MessageBox.Show($"{lines.Count}");
            foreach (var line in linesCircuit)
            {
                //MessageBox.Show($"{line.Item1.X} {line.Item1.Y} {line.Item2.X} {line.Item2.Y}");
                g.DrawLine(pen, line.Item1, line.Item2);
            }

            pen = new Pen(Color.Black, 3);
            foreach (var line in linesSkeleton)
            {
                //MessageBox.Show($"{line.Item1.X} {line.Item1.Y} {line.Item2.X} {line.Item2.Y}");
                g.DrawLine(pen, line.Item1, line.Item2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
