using CG_Lab2.lab2;
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
            linesCircuit = TextCoordsParser.GetCoordsFromTxt("C:\\Users\\Lenevo Legion 5\\source\\repos\\CG-Lab2\\lab2\\Заяц.txt");
            linesSkeleton = TextCoordsParser.GetCoordsFromTxt("C:\\Users\\Lenevo Legion 5\\source\\repos\\CG-Lab2\\lab2\\скелет.txt");

            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            Painter.DrawLines(g, linesCircuit, Color.White);
            Painter.DrawLines(g, linesSkeleton, Color.White, 3);
        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            if (rotateX.Text.Length == 0)
            {
                MessageBox.Show("Введите угол поворота", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (!int.TryParse(rotateX.Text, out int angle))
            {
                MessageBox.Show("Неверный ввод угла поворота", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Geometry.RotateLines(linesCircuit, angle);
            Geometry.RotateLines(linesSkeleton, angle);

            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            Painter.DrawLines(g, linesCircuit, Color.White);
            Painter.DrawLines(g, linesSkeleton, Color.White, 3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Move_Click(object sender, EventArgs e)
        {
            if (MoveX.Text.Length == 0 || MoveY.Text.Length == 0)
            {
                MessageBox.Show("Введите смещение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(MoveX.Text, out int dx) || !int.TryParse(MoveY.Text, out int dy))
            {
                MessageBox.Show("Неверный ввода смещения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Geometry.MoveLines(linesCircuit, dx, dy);
            Geometry.MoveLines(linesSkeleton, dx, dy);

            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            Painter.DrawLines(g, linesCircuit, Color.White);
            Painter.DrawLines(g, linesSkeleton, Color.White, 3);
        }

        private void Scale_Click(object sender, EventArgs e)
        {
            if (ScaleX.Text.Length == 0 || ScaleY.Text.Length == 0)
            {
                MessageBox.Show("Введите коэффициенты маштабирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(ScaleX.Text, out double scaleX) || !double.TryParse(ScaleY.Text, out double scaleY))
            {
                MessageBox.Show("Неверный ввода коэффициенты маштабирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Geometry.ScaleLines(linesCircuit, scaleX, scaleY);
            Geometry.ScaleLines(linesSkeleton, scaleX, scaleY);

            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            Painter.DrawLines(g, linesCircuit, Color.White);
            Painter.DrawLines(g, linesSkeleton, Color.White, 3);
        }
    }
}
