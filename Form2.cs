using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            void ProcessInput()
            {
                try
                {
                    string[] nums = textBox1.Text.Split(',');

                    if (nums.Length != 2)
                        throw new Exception("Неправильное число символов");

                    float[] floats = new float[nums.Length];

                    for (int i = 0; i < nums.Length; i++)
                    {
                        floats[i] = Convert.ToSingle(nums[i].Trim(), new CultureInfo("en-US"));
                    }

                    parent.SaveToOldItems();
                    ListView.ListViewItemCollection items = parent.GetListViewCollection();
                    foreach (ListViewItem item in items)
                    {
                        if (item.Text == $"{floats[0]}; {floats[1]}")
                            throw new Exception("Точка была уже добавлена");
                    }

                    parent.AddToListView($"{floats[0]}; {floats[1]}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ProcessInput();

        }

        private void Enter_MouseEnter(object sender, EventArgs e)
        {
            Enter.BackColor = Color.Green;
        }

        private void Enter_MouseLeave(object sender, EventArgs e)
        {
            Enter.BackColor = Color.DarkOrange;
        }

        private void Cancel_MouseEnter(object sender, EventArgs e)
        {
            Cancel.BackColor = Color.Tomato;
        }

        private void Cancel_MouseLeave(object sender, EventArgs e)
        {
            Cancel.BackColor = Color.DarkOrange;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
