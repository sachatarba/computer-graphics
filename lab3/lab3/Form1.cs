using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void whiteBackColor_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor =  Color.White;
        }

        private void yellowBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor= Color.Yellow;
        }

        private void orangeBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor= Color.Orange;
        }

        private void redBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor= Color.Red;
        }

        private void purpleBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor= Color.Purple;
        }

        private void greenBackBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor= Color.Green;
        }
    }
}
