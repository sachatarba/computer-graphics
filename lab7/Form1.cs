using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            segmentColor = segmentColorBtn.BackColor;
            rectColor = rectColorBtn.BackColor;
            resColor = resColorBtn.BackColor;

            segments = new List<(Point, Point, Color)>();
            rects = new List<(Point, Point, Color)>();
            resSegments = new List<(Point, Point, Color)>();

            translate = new Vector<float>(pictureBox1.Width / 2f, pictureBox1.Height / 2f);
            points = new List<Point>();
        }

        void DrawGrid(Graphics g)
        {
            Pen arrow = new Pen(Color.Gray, 2);
            arrow.CustomStartCap = new AdjustableArrowCap(6, 6);

            Pen pen = new Pen(Color.Gray, 1);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;


            int i = -2 * Convert.ToInt32(translate.X);

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

        private void SegmentColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                segmentColorBtn.BackColor = colorDialog1.Color;
                segmentColor = segmentColorBtn.BackColor;
            }
        }

        private void RectColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rectColorBtn.BackColor = colorDialog1.Color;
                rectColor = rectColorBtn.BackColor;
            }
        }

        private void ResColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                resColorBtn.BackColor = colorDialog1.Color;
                resColor = resColorBtn.BackColor;
            }
        }

        private void PainSegmentBtn_Click(object sender, EventArgs e)
        {
            segments.Add((new Point(Convert.ToInt32(xSegmentStart.Value), -Convert.ToInt32(ySegmentStart.Value)),
                new Point(Convert.ToInt32(xSegmentEnd.Value), -Convert.ToInt32(ySegmentEnd.Value)), segmentColor));

            pictureBox1.Refresh();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            translate.X = pictureBox1.Width / 2f;
            translate.Y = pictureBox1.Height / 2f;
            e.Graphics.TranslateTransform(translate.X, translate.Y);
            e.Graphics.Clear(Color.White);
            DrawGrid(e.Graphics);



            foreach (var rect in rects)
            {
                Pen pen = new Pen(rect.Item3);
                e.Graphics.DrawRectangle(pen, rect.Item1.X, rect.Item1.Y, rect.Item2.X,
                    rect.Item2.Y);
            }

            foreach (var segment in segments)
            {
                Pen pen = new Pen(segment.Item3);
                //Pen pen = new Pen(Color.Black);
                e.Graphics.DrawLine(pen, segment.Item1, segment.Item2);
                //MessageBox.Show($"({segment.Item1.X} {segment.Item1.Y}); ({segment.Item2.X} {segment.Item2.Y})");
            }

            foreach (var segment in resSegments)
            {
                Pen pen = new Pen(segment.Item3);
                //Pen pen = new Pen(Color.Black);
                e.Graphics.DrawLine(pen, segment.Item1, segment.Item2);
                //MessageBox.Show($"({segment.Item1.X} {segment.Item1.Y}); ({segment.Item2.X} {segment.Item2.Y})");
            }

            // отрисовка результата
        }

        private void PainRectBtn_Click(object sender, EventArgs e)
        {
            rects.Add((new Point(Convert.ToInt32(xRectLeftUp.Value), -Convert.ToInt32(yRectLeftUp.Value)),
                new Point(Convert.ToInt32(xRectRightDown.Value), Convert.ToInt32(yRectRightDown.Value)), rectColor));

            pictureBox1.Refresh();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void SolveTaskBtn_Click(object sender, EventArgs e)
        {
            resSegments.AddRange(Algorithm.GetIntersectedLine(segments, new Rectangle(rects[0].Item1.X, rects[0].Item1.Y,
                Math.Abs(rects[0].Item2.X), Math.Abs(rects[0].Item2.Y)), resColor));

            pictureBox1.Refresh();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
         //   Point point = new Point(e.X - Convert.ToInt32(translate.X), e.Y - Convert.ToInt32(translate.Y));
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X - Convert.ToInt32(translate.X), e.Y - Convert.ToInt32(translate.Y));

            points.Add(point);

            if (points.Count % 2 == 0 )
            {
                segments.Add((points[points.Count - 1], points[points.Count - 2], segmentColor));
            }

            pictureBox1.Refresh();
        }
    }
}
