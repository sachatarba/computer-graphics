﻿using CG_Lab2.lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            linesSkeleton = new List<(Point2f, Point2f)>();
            linesCircuit = new List<(Point2f, Point2f)>();
            oldCircuits = new Stack<List<(Point2f, Point2f)>>();
            oldSkeletons = new Stack<List<(Point2f, Point2f)>>();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            oldSkeletons.Push(linesSkeleton);
            oldCircuits.Push(linesCircuit);

            linesCircuit = TextCoordsParser.GetCoordsFromTxt("C:\\Users\\Lenevo Legion 5\\source\\repos\\CG-Lab2\\lab2\\Заяц.txt");
            linesSkeleton = TextCoordsParser.GetCoordsFromTxt("C:\\Users\\Lenevo Legion 5\\source\\repos\\CG-Lab2\\lab2\\скелет.txt");



            MoveAllLines(-240, 240);
            pictureBox1.Refresh();
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

        private void DrawScene(Graphics g)
        {
            g.Clear(Color.White);
            g.TranslateTransform(pictureBox1.Size.Width / 2f, pictureBox1.Size.Height / 2f);

            DrawGrid(g);

            Painter.DrawLines(g, linesCircuit, Color.Black);
            Painter.DrawLines(g, linesSkeleton, Color.Black, 3);
        }

        private void ScaleAllLines(double scaleX, double scaleY)
        {
            Geometry.ScaleLines(linesCircuit, scaleX, scaleY);
            Geometry.ScaleLines(linesSkeleton, scaleX, scaleY);
        }

        private void MoveAllLines(int dx, int dy)
        {
            Geometry.MoveLines(linesCircuit, dx, -dy);
            Geometry.MoveLines(linesSkeleton, dx, -dy);
        }

        private void RotateAllLines(int angle)
        {
            Geometry.RotateLines(linesCircuit, angle);
            Geometry.RotateLines(linesSkeleton, angle);
        }

        public void PushInStackFigure()
        {
            oldCircuits.Push(new List<(Point2f, Point2f)>(linesCircuit));
            oldSkeletons.Push(new List<(Point2f, Point2f)>(linesSkeleton));
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

            if (centerX.Text == "" ^ centerY.Text == "")
            {
                MessageBox.Show(
                    "Введите обе координаты точки центра маштабирования", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (centerX.Text != "" && centerY.Text != "")
            {
                if (!int.TryParse(centerX.Text, out int ddx) || !int.TryParse(centerY.Text, out int ddy))
                {
                    MessageBox.Show("Неверный ввод точки центра маштабирования",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PushInStackFigure();
                MoveAllLines(-ddx, -ddy);
                RotateAllLines(angle);
                MoveAllLines(ddx, ddy);
            }
            else
            {
                PushInStackFigure();
                RotateAllLines(angle);
            }

            pictureBox1.Refresh();
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
                MessageBox.Show("Неверный ввод смещения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (centerX.Text == "" ^ centerY.Text == "")
            {
                MessageBox.Show(
                    "Введите обе координаты точки центра маштабирования", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (centerX.Text != "" && centerY.Text != "")
            {
                if (!int.TryParse(centerX.Text, out int ddx) || !int.TryParse(centerY.Text, out int ddy))
                {
                    MessageBox.Show("Неверный ввод точки",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PushInStackFigure();
                MoveAllLines(-ddx, -ddy);
                MoveAllLines(dx, dy);
                MoveAllLines(ddx, ddy);
            }
            else
            {
                PushInStackFigure();
                MoveAllLines(dx, dy);
            }

            pictureBox1.Refresh();
        }

        private void Scale_Click(object sender, EventArgs e)
        {
            if (ScaleX.Text.Length == 0 || ScaleY.Text.Length == 0)
            {
                MessageBox.Show(
                    "Введите коэффициенты маштабирования", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(ScaleX.Text, out double scaleX) || !double.TryParse(ScaleY.Text, out double scaleY))
            {
                MessageBox.Show(
                    "Неверный ввод коэффициенты маштабирования", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (centerX.Text == "" ^ centerY.Text == "")
            {
                MessageBox.Show(
                    "Введите обе координаты точки центра маштабирования", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (centerX.Text != "" && centerY.Text != "")
            {
                if (!int.TryParse(centerX.Text, out int ddx) || !int.TryParse(centerY.Text, out int ddy))
                {
                    MessageBox.Show("Неверный ввод точки",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PushInStackFigure();
                MoveAllLines(-ddx, -ddy);
                ScaleAllLines(scaleX, scaleY);
                MoveAllLines(ddx, ddy);
            }
            else
            {
                PushInStackFigure();
                ScaleAllLines(scaleX, scaleY);
            }

            pictureBox1.Refresh();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (oldCircuits.Count == 0 || oldSkeletons.Count == 0)
            {
                MessageBox.Show(
                    "Достигнуто начальное состояние", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            linesCircuit = new List<(Point2f, Point2f)>(oldCircuits.Pop());
            linesSkeleton = new List<(Point2f, Point2f)>(oldSkeletons.Pop());

            pictureBox1.Refresh();
        }

        private void ButtonDown_Click(object sender, EventArgs e)
        {
            const int dy = 10;
            const int dx = 0;

            Geometry.MoveLines(linesCircuit, dx, dy);
            Geometry.MoveLines(linesSkeleton, dx, dy);

            pictureBox1.Refresh();
        }

        private void ButttonUp_Click(object sender, EventArgs e)
        {
            const int dy = -10;
            const int dx = 0;

            Geometry.MoveLines(linesCircuit, dx, dy);
            Geometry.MoveLines(linesSkeleton, dx, dy);

            pictureBox1.Refresh();
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            const int dy = 0;
            const int dx = -10;

            Geometry.MoveLines(linesCircuit, dx, dy);
            Geometry.MoveLines(linesSkeleton, dx, dy);

            pictureBox1.Refresh();
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            const int dy = 0;
            const int dx = 10;

            Geometry.MoveLines(linesCircuit, dx, dy);
            Geometry.MoveLines(linesSkeleton, dx, dy);

            pictureBox1.Refresh();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Нарисовать исходный рисунок, затем его переместить,\r\n\r\nпромасштабировать, повернуть",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Тарба Александр ИУ7-45Б",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            DrawScene(e.Graphics);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
    }
}
