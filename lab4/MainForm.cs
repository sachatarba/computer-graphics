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
            drawObjects = new List<IDrawable>();
            lineColor = Color.Black;
            backColor = Color.White;
        }

        private void WhiteBackColor_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            backColor = Color.White;
            pictureBox1.Refresh();
        }

        private void YellowBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Yellow;
            backColor = Color.Yellow;
            pictureBox1.Refresh();
        }

        private void OrangeBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Orange;
            backColor = Color.Orange;
            pictureBox1.Refresh();
        }

        private void RedBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
            backColor = Color.Red;
            pictureBox1.Refresh();
        }

        private void PurpleBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Purple;
            backColor = Color.Purple;
            pictureBox1.Refresh();
        }

        private void GreenBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Green;
            backColor = Color.Green;
            pictureBox1.Refresh();
        }

        private void DrawCircleBtn_Click(object sender, EventArgs e)
        {
            if (drawCircleFunc == null)
            {
                MessageBox.Show("Выберите алгоритм отрисовки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt32(circleRadius.Value) <= 0) 
            {
                MessageBox.Show("Неверный ввод радиуса", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            drawObjects.Add(new ColoredCircle(new PointF(Convert.ToSingle(xCenter.Value),
                Convert.ToSingle(yCenter.Value)), Convert.ToInt32(circleRadius.Value), lineColor, drawCircleFunc));
            pictureBox1.Refresh();
        }

        private void WhiteLineBtn_Click(object sender, EventArgs e)
        {
            lineColor = Color.White;
        }

        private void YellowLineBtn_Click(object sender, EventArgs e)
        {
            lineColor = Color.Yellow;
        }

        private void OrangeLineBtn_Click(object sender, EventArgs e)
        {
            lineColor = Color.Orange;
        }

        private void RedLineBtn_Click(object sender, EventArgs e)
        {
            lineColor = Color.Red;
        }

        private void PurpleLineBtn_Click(object sender, EventArgs e)
        {
            lineColor = Color.Purple;
        }

        private void GreenLineBtn_Click(object sender, EventArgs e)
        {
            lineColor = Color.Green;
        }

        private void DrawGrid(Graphics g)
        {
            Pen arrow = new Pen(Color.Gray, 2);
            //arrow.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
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

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(pictureBox1.Width / 2f, pictureBox1.Height / 2f);
            e.Graphics.Clear(backColor);
            DrawGrid(e.Graphics);
            Painter.DrawScene(e.Graphics, drawObjects);
        }

        private void LibBtn_Click(object sender, EventArgs e)
        {
            drawEllipseFunc = Painter.DrawEllipseLib;
            drawCircleFunc = Painter.DrawEllipseLib;
            SetUnChecked();
            checkBox5.Checked = true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            drawObjects.Clear();
            pictureBox1.Refresh();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void CheckBox1_Click(object sender, EventArgs e)
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
        }

        private void DrawEllipse_Click(object sender, EventArgs e)
        {
            if (drawEllipseFunc == null)
            {
                MessageBox.Show("Выберите алгоритм отрисовки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt32(ellipseHeight.Value) <= 0 || Convert.ToInt32(ellipseWidth.Value) <= 0)
            {
                MessageBox.Show("Неверные размеры эллипса", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            drawObjects.Add(new ColoredEllipse(new PointF(Convert.ToSingle(xCenter.Value),
                Convert.ToSingle(yCenter.Value)), Convert.ToInt32(ellipseHeight.Value), Convert.ToInt32(ellipseWidth.Value), lineColor, drawEllipseFunc));


            pictureBox1.Refresh();
        }

        private void DrawSetOfCircles_Click(object sender, EventArgs e)
        {
            if (drawCircleFunc == null)
            {
                MessageBox.Show("Выберите алгоритм отрисовки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt32(circleRadiusStart.Value) <= 0)
            {
                MessageBox.Show("Начальный радиус должен быть больше нуля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt32(figureStep.Value) <= 0) 
            {
                MessageBox.Show("Введите положительный шаг", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(Convert.ToInt32(circleRadiusEnd.Value) <= 0 ^ Convert.ToInt32(figureNumber.Value) <= 0))
            {
                MessageBox.Show("Введите конечный радиус или число окружностей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int number = Convert.ToInt32(figureNumber.Value);
            int endRadius = Convert.ToInt32(circleRadiusEnd.Value);
            int startRadius = Convert.ToInt32(circleRadiusStart.Value);
            int step = Convert.ToInt32(figureStep.Value);
            var (x, y) = (Convert.ToSingle(xCenter.Value), Convert.ToSingle(yCenter.Value));

            if (number != 0)
            {
                for (int i = 0; i < number; ++i)
                {
                    drawObjects.Add(new ColoredCircle(new PointF(x, y),
                        startRadius, lineColor, drawCircleFunc));
                    startRadius += step;
                }
            }
            else if (endRadius != 0)
            {
                if (endRadius <= startRadius)
                {
                    MessageBox.Show("Конечный радиус должен быть больше начального", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                while (startRadius <= endRadius)
                {
                    drawObjects.Add(new ColoredCircle(new PointF(x, y),
                        startRadius, lineColor, drawCircleFunc));
                    startRadius += step;
                }
            }

            pictureBox1.Refresh();
        }

        private void DrawSetOfEllipses_Click(object sender, EventArgs e)
        {
            if (drawEllipseFunc == null)
            {
                MessageBox.Show("Выберите алгоритм отрисовки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt32(ellipseWidthStart.Value) <= 0)
            {
                MessageBox.Show("Начальная ширина должна быть больше нуля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt32(ellipseHeightStart.Value) <= 0)
            {
                MessageBox.Show("Начальная высота должна быть больше нуля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt32(figureStep.Value) <= 0)
            {
                MessageBox.Show("Введите положительный шаг", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt32(ellipseWidthEnd.Value) <= 0 ^ Convert.ToInt32(ellipseHeightEnd.Value) <= 0)
            {
                MessageBox.Show("Введите ненулевые конечные ширину и высоту", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!((Convert.ToInt32(ellipseWidthEnd.Value) <= 0 && Convert.ToInt32(ellipseHeightEnd.Value) <= 0) ^
                Convert.ToInt32(figureNumber.Value) <= 0))
            {
                MessageBox.Show("Введите конечные ширину и высоту или число окружностей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int number = Convert.ToInt32(figureNumber.Value);
            int endWidth = Convert.ToInt32(ellipseWidthEnd.Value);
            int endHeight = Convert.ToInt32(ellipseHeightEnd.Value);
            int startWidth = Convert.ToInt32(ellipseWidthStart.Value);
            int startHeight= Convert.ToInt32(ellipseHeightStart.Value);
            int step = Convert.ToInt32(figureStep.Value);
            var (x, y) = (Convert.ToSingle(xCenter.Value), Convert.ToSingle(yCenter.Value));

            if (number != 0)
            {
                for (int i = 0; i < number; ++i)
                {
                    drawObjects.Add(new ColoredEllipse(new PointF(x, y),
                        startHeight, startWidth, lineColor, drawEllipseFunc));
                    startHeight += step;
                    startWidth += step;
                }
            }
            else if (endWidth != 0 && endHeight != 0)
            {
                if (endWidth <= startWidth || endHeight <= endWidth)
                {
                    MessageBox.Show("Конечные ширина и высота должны быть больше начальных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                while (startWidth <= endWidth && startHeight <= endHeight)
                {
                    drawObjects.Add(new ColoredEllipse(new PointF(x, y),
                        startHeight, startWidth, lineColor, drawEllipseFunc));
                    startHeight += step;
                    startWidth += step;
                }
            }

            pictureBox1.Refresh();
        }

        private void BrezenhemBtn_Click(object sender, EventArgs e)
        {
            SetUnChecked();
            checkBox4.Checked = true;
            drawCircleFunc = Painter.DrawCircleBrezenhem;
            drawEllipseFunc = Painter.DrawEllipseBrezenhem;
        }
    }
}
