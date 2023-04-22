using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
