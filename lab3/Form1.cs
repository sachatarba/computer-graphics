using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lines = new List<(PointF, PointF, Color, Painter.DrawLineFunc)> ();
            spectrums = new List<(PointF, float, float, Color, Painter.DrawLineFunc)>();
            drawFunc= null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void whiteBackColor_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor =  Color.White;
            backColor = Color.White;
            pictureBox1.Refresh();
        }

        private void yellowBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor= Color.Yellow;
            backColor= Color.Yellow;
            pictureBox1.Refresh();
        }

        private void orangeBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor= Color.Orange;
            backColor= Color.Orange;
            pictureBox1.Refresh();
        }

        private void redBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor= Color.Red;
            backColor= Color.Red;
            pictureBox1.Refresh();
        }

        private void purpleBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor= Color.Purple;
            backColor= Color.Purple;
            pictureBox1.Refresh();
        }

        private void greenBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor= Color.Green;
            backColor= Color.Green;
            pictureBox1.Refresh();
        }

        private void drawLineBtn_Click(object sender, EventArgs e)
        {
            if (drawFunc == null)
            {
                MessageBox.Show("Выберите алгоритм отрисовки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToSingle(xBeg.Value) == Convert.ToSingle(xEnd.Value) &&
                Convert.ToSingle(xEnd.Value) == Convert.ToSingle(yEnd.Value))
            {
                MessageBox.Show("Введите координаты не вырожденной прямой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lines.Add(
                (new PointF(Convert.ToSingle(xBeg.Value), Convert.ToSingle(yBeg.Value)),
                 new PointF(Convert.ToSingle(xEnd.Value), Convert.ToSingle(yEnd.Value)),
                 lineColor, drawFunc));
            
            pictureBox1.Refresh();
        }

        private void whiteLineBtn_Click(object sender, EventArgs e)
        {
            lineColor = Color.White;
        }

        private void yellowLineBtn_Click(object sender, EventArgs e)
        {
            lineColor= Color.Yellow;
        }

        private void orangeLineBtn_Click(object sender, EventArgs e)
        {
            lineColor= Color.Orange;
        }

        private void redLineBtn_Click(object sender, EventArgs e)
        {
            lineColor= Color.Red;
        }

        private void purpleLineBtn_Click(object sender, EventArgs e)
        {
            lineColor= Color.Purple;
        }

        private void greenLineBtn_Click(object sender, EventArgs e)
        {
            lineColor= Color.Green;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Painter.DrawScene(e.Graphics, lines, spectrums, backColor);
        }

        private void libBtn_Click(object sender, EventArgs e)
        {
            drawFunc = Painter.DrawLineLib;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            lines.Clear();
            pictureBox1.Refresh();
        }

        private void drawSpecBtn_Click(object sender, EventArgs e)
        {
            if (drawFunc == null)
            {
                MessageBox.Show("Выберите алгоритм отрисовки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lengthSpec.Value == 0)
            {
                MessageBox.Show("Введите ненулевую длину отрезка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (angleSpec.Value == 0)
            {
                MessageBox.Show("Введите ненулевой угол", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (angleSpec.Value > 180)
            {
                MessageBox.Show("Введите меньший угол", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Painter.DrawSpectrum(e)
            PointF center = new PointF(Convert.ToSingle(xCenter.Value), Convert.ToSingle(yCenter.Value));
            spectrums.Add((center, Convert.ToSingle(lengthSpec.Value), Convert.ToSingle(angleSpec.Value), lineColor, drawFunc));
            pictureBox1.Refresh();
        }
    }
}
