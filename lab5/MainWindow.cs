using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            paintColor = new Color();
            points = new List<Point>();
            figures = new List<List<Point>>();
            paintColor = Color.Green;
            translate = new Vector<float>(pictureBox1.Width / 2f, pictureBox1.Height / 2f);
        }

        private void ChooseColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel) 
            {
                return;
            }

            paintColor = colorDialog1.Color;
            currentColorBtn.BackColor = paintColor;
            //throw new Exception();
        }

        private void AddEdgeToListView()
        {
            if (points.Count >= 2)
            {
                listPoints.Items.Add($"{listPoints.Items.Count + 1})" + "{ " + $"({points.ElementAt(points.Count - 2).X}; {-points.ElementAt(points.Count - 2).Y}); " +
                    $"({points.ElementAt(points.Count - 1).X}; {-points.ElementAt(points.Count - 1).Y})" + " }");
            }
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X - Convert.ToInt32(translate.X), e.Y - Convert.ToInt32(translate.Y));
            if (!points.Contains(point))
            {
                points.Add(point);
            }
            else
            {
                MessageBox.Show("Точка уже была добавлена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //points.Add();
            pictureBox1.Refresh();

            AddEdgeToListView();
        }

        private void DrawGrid(Graphics g)
        {
            Pen arrow = new Pen(Color.Gray, 2);
            arrow.CustomStartCap = new AdjustableArrowCap(6, 6);

            Pen pen = new Pen(Color.Gray, 1);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;


            int i = - 2 * Convert.ToInt32(translate.X);

            while (i * 50 < 2 * Convert.ToInt32(translate.X))
            {
                g.DrawLine(pen, i * 50, -translate.Y, i * 50, translate.Y);
                ++i;
            }
            int j = -2 * Convert.ToInt32(translate.Y);
            while (j * 10 < 2 * Convert.ToInt32(translate.X))
            {
                g.DrawLine(pen, -translate.X, j * 50, translate.X, j * 50);
                ++j;
            }

            g.DrawLine(arrow, translate.X, 0, -translate.X, 0);
            g.DrawLine(arrow, 0, -translate.Y, 0, translate.Y);
        }

        public void FillFigure(object data)
        {
            FillFigure((Graphics)data);
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            translate.X = pictureBox1.Width / 2f;
            translate.Y = pictureBox1.Height / 2f;
            e.Graphics.TranslateTransform(translate.X, translate.Y);
            e.Graphics.Clear(Color.White);
            DrawGrid(e.Graphics);
            //Bitmap bitmap = pictureBox1.Image as Bitmap;
            if (wasFilled)
            {
                //Thread fillingThread = new Thread(() => Painter.FillFigure(e.Graphics, points, paintColor));
                //Thread fillingThread = new Thread(FillFigure);
                //fillingThread.Start(e.Graphics);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                FillFigure(e.Graphics);
                sw.Stop();
                TimeSpan timeSpan = sw.Elapsed;
                label5.Text = string.Format("Время закраски: {0:f3}с", timeSpan.TotalSeconds);
            }

            foreach (List<Point> points in figures)
            {
                Painter.DrawLines(e.Graphics, points, Color.Black);
                Painter.DrawPoints(e.Graphics, points, Color.Black);
            }

            Painter.DrawLines(e.Graphics, points, Color.Black);
            Painter.DrawPoints(e.Graphics, points, Color.Black);

            //Painter.FillFigure(bitmap, points, paintColor);
        }

        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void AddPoint_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(xInput.Value);
            int y = Convert.ToInt32(yInput.Value);
            Point point = new Point(x, -y);
            if (!points.Contains(point))
            {
                points.Add(point);
            }
            else
            {
                MessageBox.Show("Точка уже была добавлена!","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddEdgeToListView();
            wasFilled = false;
            pictureBox1.Refresh();
        }

        private void CloseFigureBtn_Click(object sender, EventArgs e)
        {
            if (points.Count <= 2)
            {
                MessageBox.Show("Недостаточно точек, чтобы замкнуть фигуру!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            points.Add(points.ElementAt(0));
            figures.Add(new List<Point>(points));
            points.Clear();
            AddEdgeToListView();
            pictureBox1.Refresh();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (paintThread != null && paintThread.IsAlive)
            {
                paintThread.Abort();
            }

            points.Clear();
            figures.Clear();
            listPoints.Items.Clear();
            wasFilled = false;
            pictureBox1.Refresh(); 
        }

        void FillFigure(Graphics g)
        {
            //Graphics g = pictureBox1.CreateGraphics();
            //g.TranslateTransform(translate.X, translate.Y);
            
            Painter.FillFigure(g, figures, paintColor);
        }

        private void PaintBtn_Click(object sender, EventArgs e)
        {
            if (figures.Count == 0)
            {
                MessageBox.Show("Фигура не была замкнута!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (paintThread != null && paintThread.IsAlive)
            {
                paintThread.Abort();
            }

            if (!timeLocking)
            {
                wasFilled = true;
                pictureBox1.Refresh();
            }
            else
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.TranslateTransform(translate.X, translate.Y);
                //Thread fillFIgure = new Thread(FillFigure);
                paintThread = new Thread(FillFigure);
                paintThread.Name = "Paint";
                paintThread.Start(g);
            }
            //Bitmap bitmap = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);

            //Painter.DrawLines(e.Graphics, points, Color.Black);
            //translate.X = pictureBox1.Width / 2f;
            //translate.Y = pictureBox1.Height / 2f;
            //g.Clear(Color.White);


        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            timeLocking = false;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            timeLocking = true;
        }
    }
}
