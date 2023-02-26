namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.add1 = new System.Windows.Forms.Button();
            this.del1 = new System.Windows.Forms.Button();
            this.clear1 = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Solve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.authorInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Honeydew;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(285, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(678, 637);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            // 
            // add1
            // 
            this.add1.BackColor = System.Drawing.Color.DarkOrange;
            this.add1.Location = new System.Drawing.Point(0, 259);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(140, 29);
            this.add1.TabIndex = 3;
            this.add1.Text = "Добавить";
            this.add1.UseVisualStyleBackColor = false;
            this.add1.Click += new System.EventHandler(this.Add1_Click);
            this.add1.MouseEnter += new System.EventHandler(this.Add1_MouseEnter);
            this.add1.MouseLeave += new System.EventHandler(this.Add1_MouseLeave);
            // 
            // del1
            // 
            this.del1.BackColor = System.Drawing.Color.DarkOrange;
            this.del1.Location = new System.Drawing.Point(146, 259);
            this.del1.Name = "del1";
            this.del1.Size = new System.Drawing.Size(139, 29);
            this.del1.TabIndex = 4;
            this.del1.Text = "Удалить";
            this.del1.UseVisualStyleBackColor = false;
            this.del1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Del1_MouseClick);
            this.del1.MouseEnter += new System.EventHandler(this.Del1_MouseEnter);
            this.del1.MouseLeave += new System.EventHandler(this.Del1_MouseLeave);
            // 
            // clear1
            // 
            this.clear1.BackColor = System.Drawing.Color.DarkOrange;
            this.clear1.Location = new System.Drawing.Point(0, 294);
            this.clear1.Name = "clear1";
            this.clear1.Size = new System.Drawing.Size(285, 29);
            this.clear1.TabIndex = 5;
            this.clear1.Text = "Очистить все";
            this.clear1.UseVisualStyleBackColor = false;
            this.clear1.Click += new System.EventHandler(this.Clear1_Click);
            this.clear1.MouseEnter += new System.EventHandler(this.Clear1_MouseEnter);
            this.clear1.MouseLeave += new System.EventHandler(this.Clear1_MouseLeave);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.BackColor = System.Drawing.Color.DarkOrange;
            this.cancel.Location = new System.Drawing.Point(0, 600);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(285, 29);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Отмена последнего действия";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            this.cancel.MouseEnter += new System.EventHandler(this.Info_MouseEnter);
            this.cancel.MouseLeave += new System.EventHandler(this.Info_MouseLeave);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.CheckBoxes = true;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 53);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 60, 3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(285, 202);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(0, 351);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(285, 213);
            this.listView2.TabIndex = 12;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Solve);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listView2);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.clear1);
            this.panel1.Controls.Add(this.del1);
            this.panel1.Controls.Add(this.add1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 637);
            this.panel1.TabIndex = 13;
            // 
            // Solve
            // 
            this.Solve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Solve.BackColor = System.Drawing.Color.DarkOrange;
            this.Solve.Location = new System.Drawing.Point(0, 570);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(285, 29);
            this.Solve.TabIndex = 14;
            this.Solve.Text = "Решить задачу";
            this.Solve.UseVisualStyleBackColor = false;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            this.Solve.MouseEnter += new System.EventHandler(this.Solve_MouseEnter);
            this.Solve.MouseLeave += new System.EventHandler(this.Solve_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Swis721 BdCnOul BT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "РЕШЕНИЕ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(285, 27);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorInfoToolStripMenuItem,
            this.programInfoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(65, 24);
            this.toolStripDropDownButton1.Text = "Меню";
            // 
            // authorInfoToolStripMenuItem
            // 
            this.authorInfoToolStripMenuItem.Name = "authorInfoToolStripMenuItem";
            this.authorInfoToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.authorInfoToolStripMenuItem.Text = "Информация об авторе";
            this.authorInfoToolStripMenuItem.Click += new System.EventHandler(this.AuthorInfoToolStripMenuItem_Click);
            // 
            // programInfoToolStripMenuItem
            // 
            this.programInfoToolStripMenuItem.Name = "programInfoToolStripMenuItem";
            this.programInfoToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.programInfoToolStripMenuItem.Text = "Информация о задаче";
            this.programInfoToolStripMenuItem.Click += new System.EventHandler(this.ProgramInfoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 24);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.GreenYellow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Swis721 BdCnOul BT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "МНОЖЕСТВО ТОЧЕК";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(868, 543);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 94);
            this.panel2.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(54, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 25);
            this.button4.TabIndex = 16;
            this.button4.Text = "->";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-2, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 25);
            this.button3.TabIndex = 15;
            this.button3.Text = "<---";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "|v";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "^|";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(963, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Привет от МТ3-22:)";
            this.MaximumSizeChanged += new System.EventHandler(this.Form1_MaximumSizeChanged);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button add1;
        private Button del1;
        private Button clear1;
        private Button cancel;
        internal List<ListViewItem> oldItems; 
        private ListView listView2;
        private Panel panel1;
        private Label label2;
        private Button Solve;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem authorInfoToolStripMenuItem;
        private ToolStripMenuItem programInfoToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripLabel toolStripLabel1;
        private Label label1;
        private ListView listView1;
        private Circle solution;
        private int diffx, diffy;
        private double scale;
        private Panel panel2;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        //private Dictionary<ListViewItem, ColoredPoint> coloredPoints;
        //private Dictionary<ListViewItem, Circle> coloredCircles;
        //private PointWith
    }
}