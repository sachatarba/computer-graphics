using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void segmentColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                segmentColorBtn.BackColor = colorDialog1.Color;
                segmentColor = segmentColorBtn.BackColor;
            }
        }

        private void rectColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rectColorBtn.BackColor = colorDialog1.Color;
                rectColor = rectColorBtn.BackColor;
            }
        }

        private void resColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                resColorBtn.BackColor = colorDialog1.Color;
                resColor = resColorBtn.BackColor;
            }
        }

        private void xRectRightDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PainSegmentBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
