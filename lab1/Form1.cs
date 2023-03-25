using System.Drawing;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            oldItems = new();
            (diffx, diffy) = (0, 0);
            scale = 1;
        }

        internal void SaveToOldItems()
        {
            oldItems.Clear();
            foreach (ListViewItem item in listView1.Items) 
            {
                oldItems.Add(item);
            }
        }

        private void ReDrawPoints(Color color, int diffX = 0, int diffY = 0, double scale = 1)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.Honeydew);
            Painter.DrawPoints(g, ListViewParser.CoordsParser(listView1), color, diffX, diffY, scale);
            listView2.Clear();
        }

        private void DrawPoints(Color color, int diffX = 0, int diffY = 0, double scale = 1)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Painter.DrawPoints(g, ListViewParser.CoordsParser(listView1), color, diffX, diffY, scale);
        }

        internal void AddToListView(string text)
        {
            listView1.Items.Add(text);
        }

        internal ListView.ListViewItemCollection GetListViewCollection()
        {
            return listView1.Items;
        }

        private void Add1_MouseEnter(object sender, EventArgs e)
        {
            add1.BackColor = Color.Green;
        }

        private void Add1_MouseLeave(object sender, EventArgs e)
        {
            add1.BackColor = Color.DarkOrange;
        }

        private void Del1_MouseEnter(object sender, EventArgs e)
        {
            del1.BackColor = Color.Tomato;
        }

        private void Del1_MouseLeave(object sender, EventArgs e)
        {
            del1.BackColor = Color.DarkOrange;
        }

        private void Clear1_MouseEnter(object sender, EventArgs e)
        {
            clear1.BackColor = Color.Red;
        }

        private void Clear1_MouseLeave(object sender, EventArgs e)
        {
            clear1.BackColor= Color.DarkOrange;
        }

        private void Info_MouseEnter(object sender, EventArgs e)
        {
            cancel.BackColor = Color.Tomato;
        }

        private void Info_MouseLeave(object sender, EventArgs e)
        {
            cancel.BackColor = Color.DarkOrange;
        }


        private void Add1_Click(object sender, EventArgs e)
        {
            Form2 input = new(this);
            input.ShowDialog();
            ReDrawPoints(Color.Blue, diffx, diffy);
            solution = null;
        }

        private void Clear1_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Вы точно хотите удалить все точки?", "Удаление точек", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SaveToOldItems();
                    listView1.Items.Clear();
                    ReDrawPoints(Color.Blue);
                    solution = null;
                }
            }
            else
            {
                MessageBox.Show(
                    "Пустой список точек:(", "Удаление точек", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Del1_MouseClick(object sender, MouseEventArgs e)
        {
            if (ListViewParser.ChooseActivatedOrCheckedPoints(listView1).Count != 0)
            {
                DialogResult result = MessageBox.Show(
                "Вы точно хотите удалить данные точки?", "Удаление точек", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SaveToOldItems();
                    foreach (ListViewItem lw in listView1.Items)
                    {
                        if (lw.Checked || lw.Selected)
                        {
                            lw.Remove();
                        }
                    }
                }

                ReDrawPoints(Color.Blue);
                solution = null;
            }
            else
            {
                MessageBox.Show(
                "Не выбраны точки для удаления:(", "Удаление точек", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Solve_Click(object sender, EventArgs e)
        {
            try
            {
                Graphics g = pictureBox1.CreateGraphics();
                //g.Clear(Color.Honeydew);

                List<Point> points = ListViewParser.CoordsParser(listView1);

                //Painter.DrawPoints(g, points, Color.Blue);
                solution = Minimizer.FindMinRadius(points, Minimizer.FindNearestPoint(points));
                //Painter.DrawCirlce(g, circle, Color.Red);
                
                //solution = circle;
                //int i = 0;

                //if (circle.Center + circle.)
                var (cx, cy) = (pictureBox1.Width / 2, pictureBox1.Height / 2);

                (diffx, diffy) = (-solution.Center.X + cx, -solution.Center.Y + cy);

                if (cx + solution.Radius > pictureBox1.Width ||
                    cx - solution.Radius < 0 || cy - solution.Radius < 0 ||
                    cy + solution.Radius > pictureBox1.Height)
                {
                    scale = Convert.ToDouble(solution.Radius) / Math.Max(pictureBox1.Height, pictureBox1.Width); 
                }
                else
                {
                    scale = 1;
                }

                DrawScene();

                //ReDrawPoints(Color.Blue, diffx, diffy);
                //DrawCircleIfItExists();
                //Painter.DrawCirlce(g, circle, Color.Red, -diffx, -diffy);

                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Solve_MouseHover(object sender, EventArgs e)
        {
            Solve.BackColor= Color.Green;
        }

        private void Solve_MouseLeave(object sender, EventArgs e)
        {
            Solve.BackColor = Color.DarkOrange;
        }

        private void Solve_MouseEnter(object sender, EventArgs e)
        {
            Solve.BackColor = Color.Green;
        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Тарба Александр ИУ7-45Б. " +
                "Программа предназначена для вычисления окружности минимального радиуса, " +
                "проходящую через точку, сумма расстояний от которой до других минимальна.", 
                "Автор и назначение программы", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AuthorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тарба Александр ИУ7-45Б", "Автор", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ProgramInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа предназначена для вычисления окружности минимального радиуса, " +
                "проходящую через точку, сумма расстояний от которой до других минимальна.",
                "Назначение программы", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach (ListViewItem item in oldItems)
            {
                listView1.Items.Add(item);
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            SaveToOldItems();
            //Graphics g = pictureBox1.CreateGraphics();
            //Point point = new(e.X, e.Y);
            listView1.Items.Add($"{Convert.ToSingle((e.X  - diffx) / scale)}; {Convert.ToSingle((e.Y - diffy) / scale)}");
            ReDrawPoints(Color.Blue, diffx, diffy, scale);
            solution = null;
        }


        private void DrawScene()
        {
            ReDrawPoints(Color.Blue, diffx, diffy, scale);
            DrawCircleIfItExists();
        }
        private void DrawCircleIfItExists()
        {
            if (solution != null)
            {
                Graphics g = pictureBox1.CreateGraphics();
                listView2.Items.Add(new ListViewItem($"Радиус: {solution.Radius}"));
                listView2.Items.Add(new ListViewItem($"Центр: {solution.Center.X}; {solution.Center.Y}"));

                int i = 1;
                Painter.DrawCirlce(g, solution, Color.OrangeRed, diffx, diffy, scale);
                foreach (Point point in solution.Points)
                {
                    Painter.DrawPoint(g, point, Color.OrangeRed, diffx, diffy, scale);
                    listView2.Items.Add(new ListViewItem($"{i++}-я точка окружности: {point.X}; {point.Y}"));
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            diffy += 10;
            DrawScene();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            diffy -= 10;
            DrawScene();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            diffx += 10;
            DrawScene();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            diffx -= 10;
            DrawScene();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            DrawScene();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            DrawScene();
        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {
            DrawScene();
        }



        //private void HighlightPoints()
        //{
        //    Graphics g = pictureBox1.CreateGraphics();
        //    foreach (ListViewItem item in listView1.Items)
        //    {
        //        Point point = ListViewParser.ToPoint(item);

        //        if (item.Checked || item.Selected)
        //        {
        //            Painter.DrawCirlce(g, new Circle(point, 10), Color.DarkGreen);
        //        }
        //        else
        //        {
        //            Painter.DrawCirlce(g, new Circle(point, 10), Color.Honeydew);
        //        }
        //    }
        //}

        //private void ListView1_ItemCheck(object sender, ItemCheckEventArgs e)
        //{
        //    HighlightPoints();
        //}

        //private void ListView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        //{
        //    HighlightPoints();
        //}

        //private void ListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        //{
        //    HighlightPoints();
        //}

        //private void Form1_SizeChanged(object sender, EventArgs e)
        //{

        //}
    }
}