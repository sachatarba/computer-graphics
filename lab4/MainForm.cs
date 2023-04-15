using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void whiteBackColor_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            backColor = Color.White;
            pictureBox1.Refresh();
        }

        private void yellowBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Yellow;
            backColor = Color.Yellow;
            pictureBox1.Refresh();
        }

        private void orangeBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Orange;
            backColor = Color.Orange;
            pictureBox1.Refresh();
        }

        private void redBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
            backColor = Color.Red;
            pictureBox1.Refresh();
        }

        private void purpleBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Purple;
            backColor = Color.Purple;
            pictureBox1.Refresh();
        }

        private void greenBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Green;
            backColor = Color.Green;
            pictureBox1.Refresh();
        }

        private void drawLineBtn_Click(object sender, EventArgs e)
        {
            //if (drawFunc == null)
            //{
            //    MessageBox.Show("Выберите алгоритм отрисовки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            if (Convert.ToSingle(xBeg.Value) == Convert.ToSingle(xEnd.Value) &&
                Convert.ToSingle(yBeg.Value) == Convert.ToSingle(yEnd.Value))
            {
                MessageBox.Show("Введите координаты не вырожденной прямой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //lines.Add(
            //    (new PointF(Convert.ToSingle(xBeg.Value), -Convert.ToSingle(yBeg.Value)),
            //     new PointF(Convert.ToSingle(xEnd.Value), -Convert.ToSingle(yEnd.Value)),
            //     lineColor, drawFunc));

            pictureBox1.Refresh();
        }

        private void whiteLineBtn_Click(object sender, EventArgs e)
        {
            lineColor = Color.White;
        }

        private void yellowLineBtn_Click(object sender, EventArgs e)
        {
            lineColor = Color.Yellow;
        }

        private void orangeLineBtn_Click(object sender, EventArgs e)
        {
            lineColor = Color.Orange;
        }

        private void redLineBtn_Click(object sender, EventArgs e)
        {
            lineColor = Color.Red;
        }

        private void purpleLineBtn_Click(object sender, EventArgs e)
        {
            lineColor = Color.Purple;
        }

        private void greenLineBtn_Click(object sender, EventArgs e)
        {
            lineColor = Color.Green;
        }

        private void DrawGrid(Graphics g)
        {
            Pen arrow = new Pen(Color.Gray, 2);
            arrow.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            arrow.CustomStartCap = new AdjustableArrowCap(6, 6);

            Pen pen = new Pen(Color.Gray, 1);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;


            int i = -pictureBox1.Size.Width;

            while (i * 50 < pictureBox1.Size.Width)
            {
                g.DrawLine(pen, i * 50, -pictureBox1.Size.Height / 2f, i * 50, pictureBox1.Size.Height / 2f);
                ++i;
            }
            int j = -pictureBox1.Size.Height;
            while (j * 10 < pictureBox1.Size.Height)
            {
                g.DrawLine(pen, -pictureBox1.Size.Width / 2f, j * 50, pictureBox1.Size.Width / 2f, j * 50);
                ++j;
            }

            g.DrawLine(arrow, pictureBox1.Size.Width / 2f, 0, -pictureBox1.Size.Width / 2f, 0);
            g.DrawLine(arrow, 0, -pictureBox1.Size.Height / 2f, 0, pictureBox1.Size.Height / 2f);

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(pictureBox1.Width / 2f, pictureBox1.Height / 2f);
            e.Graphics.Clear(backColor);
            DrawGrid(e.Graphics);
            //Painter.DrawScene(e.Graphics, lines, spectrums, backColor);
            //e.Graphics.DrawLine(new Pen(Color.Red), 0, 40, 0, 0);
        }

        private void libBtn_Click(object sender, EventArgs e)
        {
            //drawFunc = Painter.DrawLineLib;
            SetUnChecked();
            checkBox6.Checked = true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            //lines.Clear();
            //spectrums.Clear();
            pictureBox1.Refresh();
        }

        private void drawSpecBtn_Click(object sender, EventArgs e)
        {
            //if (drawFunc == null)
            //{
            //    MessageBox.Show("Выберите алгоритм отрисовки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

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
            PointF center = new PointF(Convert.ToSingle(xCenter.Value), -Convert.ToSingle(yCenter.Value));
            //spectrums.Add((center, Convert.ToSingle(lengthSpec.Value), Convert.ToSingle(angleSpec.Value), lineColor, drawFunc));
            pictureBox1.Refresh();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void brezFloatBtn_Click(object sender, EventArgs e)
        {
            //drawFunc = Painter.DrawBrezenhemFloat;
            SetUnChecked();
            checkBox2.Checked = true;
        }

        private void brezIntBtn_Click(object sender, EventArgs e)
        {
            //drawFunc = Painter.DrawBrezenhemInteger;
            SetUnChecked();
            checkBox3.Checked = true;
        }

        private void brezAdBtn_Click(object sender, EventArgs e)
        {
            //drawFunc = Painter.DrawBrezenhemSmooth;
            SetUnChecked();
            checkBox4.Checked = true;
        }

        private void cdaBtn_Click(object sender, EventArgs e)
        {
            //drawFunc = Painter.DrawDda;
            SetUnChecked();
            checkBox1.Checked = true;
        }

        private void vuBtn_Click(object sender, EventArgs e)
        {
            //drawFunc = Painter.DrawVu;
            SetUnChecked();
            checkBox5.Checked = true;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (sender is CheckBox)
                ((CheckBox)sender).Checked = !((CheckBox)sender).Checked;
        }

        private void SetUnChecked()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Plot plot = new Plot();

            //plot.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //PlotsSteps plotsSteps = new PlotsSteps();
            //plotsSteps.ShowDialog();
        }
    }
}
