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
            linesSkeleton = new List<(Point, Point)>();
            linesCircuit = new List<(Point, Point)>();
            oldCircuits = new Stack<List<(Point, Point)>>();
            oldSkeletons = new Stack<List<(Point, Point)>>();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            oldSkeletons.Push(linesSkeleton);
            oldCircuits.Push(linesCircuit);

            linesCircuit = TextCoordsParser.GetCoordsFromTxt("C:\\Users\\Lenevo Legion 5\\source\\repos\\CG-Lab2\\lab2\\Заяц.txt");
            linesSkeleton = TextCoordsParser.GetCoordsFromTxt("C:\\Users\\Lenevo Legion 5\\source\\repos\\CG-Lab2\\lab2\\скелет.txt");


            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            Painter.DrawLines(g, linesCircuit, Color.White);
            Painter.DrawLines(g, linesSkeleton, Color.White, 3);
        }


        private void DrawScene()
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            Painter.DrawLines(g, linesCircuit, Color.White);
            Painter.DrawLines(g, linesSkeleton, Color.White, 3);
        }

        private void ScaleAllLines(double scaleX, double scaleY)
        {
            Geometry.ScaleLines(linesCircuit, scaleX, scaleY);
            Geometry.ScaleLines(linesSkeleton, scaleX, scaleY);
        }

        private void MoveAllLines(int dx, int dy)
        {
            Geometry.MoveLines(linesCircuit, dx, dy);
            Geometry.MoveLines(linesSkeleton, dx, dy);
        }

        private void RotateAllLines(int angle)
        {
            Geometry.RotateLines(linesCircuit, angle);
            Geometry.RotateLines(linesSkeleton, angle);
        }

        public void PushInStackFigure()
        {
            oldCircuits.Push(new List<(Point, Point)>(linesCircuit));
            oldSkeletons.Push(new List<(Point, Point)>(linesSkeleton));
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
                    MessageBox.Show("Неверный ввод точки",
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

            DrawScene();
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

            DrawScene();
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

            DrawScene();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (oldCircuits.Count == 0 || oldSkeletons.Count == 0)
            {
                MessageBox.Show(
                    "Достигнуто начальное состояние", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            linesCircuit = new List<(Point, Point)>(oldCircuits.Pop());
            linesSkeleton = new List<(Point, Point)>(oldSkeletons.Pop());

            DrawScene();     
        }

        private void ButtonDown_Click(object sender, EventArgs e)
        {
            const int dy = 10;
            const int dx = 0;

            Geometry.MoveLines(linesCircuit, dx, dy);
            Geometry.MoveLines(linesSkeleton, dx, dy);

            DrawScene();
        }

        private void ButttonUp_Click(object sender, EventArgs e)
        {
            const int dy = -10;
            const int dx = 0;

            Geometry.MoveLines(linesCircuit, dx, dy);
            Geometry.MoveLines(linesSkeleton, dx, dy);

            DrawScene();
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            const int dy = 0;
            const int dx = -10;

            Geometry.MoveLines(linesCircuit, dx, dy);
            Geometry.MoveLines(linesSkeleton, dx, dy);

            DrawScene();
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            const int dy = 0;
            const int dx = 10;

            Geometry.MoveLines(linesCircuit, dx, dy);
            Geometry.MoveLines(linesSkeleton, dx, dy);

            DrawScene();
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
    }
}
