using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            paintColor = Color.Green;
            translate = new Vector<float>(pictureBox1.Width / 2f, pictureBox1.Height / 2f); 
        }

        private void ChooseColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel) 
            {
                return;
            }

            currentColorBtn.BackColor = colorDialog1.Color;
            //throw new Exception();
        }

        private void AddEdgeToListView()
        {
            if (points.Count >= 2)
            {
                listPoints.Items.Add($"{listPoints.Items.Count + 1})" + "{ " + $"({points.ElementAt(points.Count - 2).X}; {points.ElementAt(points.Count - 2).Y}); " +
                    $"({points.ElementAt(points.Count - 1).X}; {points.ElementAt(points.Count - 1).Y})" + " }");
            }
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X - Convert.ToInt32(translate.X), e.Y - Convert.ToInt32(translate.Y)));
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

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            translate.X = pictureBox1.Width / 2f;
            translate.Y = pictureBox1.Height / 2f;
            e.Graphics.TranslateTransform(translate.X, translate.Y);
            e.Graphics.Clear(Color.White);
            DrawGrid(e.Graphics);
            //Bitmap bitmap = pictureBox1.Image as Bitmap;
            Painter.DrawLines(e.Graphics, points, Color.Black);
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

            points.Add(new Point(x, y));

            AddEdgeToListView();
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
            AddEdgeToListView();
            pictureBox1.Refresh();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            points.Clear();
            listPoints.Items.Clear();
            pictureBox1.Refresh(); 
        }

        void FillFigure()
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.TranslateTransform(translate.X, translate.Y);
            Painter.FillFigure(g, points, paintColor);
        }

        private void PaintBtn_Click(object sender, EventArgs e)
        {
            //Bitmap bitmap = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);

            //Painter.DrawLines(e.Graphics, points, Color.Black);
            translate.X = pictureBox1.Width / 2f;
            translate.Y = pictureBox1.Height / 2f;
            //g.Clear(Color.White);
            Graphics g = pictureBox1.CreateGraphics();
            g.TranslateTransform(translate.X, translate.Y);   
            Thread fillFIgure = new Thread(FillFigure);
            fillFIgure.Start();
        }
    }
}
