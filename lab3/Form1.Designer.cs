using System.Collections.Generic;
using System.Drawing;

namespace lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.drawLbl = new System.Windows.Forms.Label();
            this.drawSpecBtn = new System.Windows.Forms.Button();
            this.lengthSpec = new System.Windows.Forms.NumericUpDown();
            this.angleSpec = new System.Windows.Forms.NumericUpDown();
            this.yCenter = new System.Windows.Forms.NumericUpDown();
            this.xCenter = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.drawLineBtn = new System.Windows.Forms.Button();
            this.yEnd = new System.Windows.Forms.NumericUpDown();
            this.xEnd = new System.Windows.Forms.NumericUpDown();
            this.yBeg = new System.Windows.Forms.NumericUpDown();
            this.xBeg = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.greenBackBtn = new System.Windows.Forms.Button();
            this.purpleBackBtn = new System.Windows.Forms.Button();
            this.redBackBtn = new System.Windows.Forms.Button();
            this.orangeBackBtn = new System.Windows.Forms.Button();
            this.yellowBackBtn = new System.Windows.Forms.Button();
            this.whiteBackColor = new System.Windows.Forms.Button();
            this.greenLineBtn = new System.Windows.Forms.Button();
            this.purpleLineBtn = new System.Windows.Forms.Button();
            this.redLineBtn = new System.Windows.Forms.Button();
            this.orangeLineBtn = new System.Windows.Forms.Button();
            this.yellowLineBtn = new System.Windows.Forms.Button();
            this.whiteLineBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chooseColorLineLbl = new System.Windows.Forms.Label();
            this.colorLbl = new System.Windows.Forms.Label();
            this.libBtn = new System.Windows.Forms.Button();
            this.vuBtn = new System.Windows.Forms.Button();
            this.brezAdBtn = new System.Windows.Forms.Button();
            this.brezIntBtn = new System.Windows.Forms.Button();
            this.brezFloatBtn = new System.Windows.Forms.Button();
            this.cdaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.infoTask = new System.Windows.Forms.ToolStripMenuItem();
            this.infoAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthSpec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleSpec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xBeg)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.drawLbl);
            this.panel1.Controls.Add(this.drawSpecBtn);
            this.panel1.Controls.Add(this.lengthSpec);
            this.panel1.Controls.Add(this.angleSpec);
            this.panel1.Controls.Add(this.yCenter);
            this.panel1.Controls.Add(this.xCenter);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.drawLineBtn);
            this.panel1.Controls.Add(this.yEnd);
            this.panel1.Controls.Add(this.xEnd);
            this.panel1.Controls.Add(this.yBeg);
            this.panel1.Controls.Add(this.xBeg);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.greenBackBtn);
            this.panel1.Controls.Add(this.purpleBackBtn);
            this.panel1.Controls.Add(this.redBackBtn);
            this.panel1.Controls.Add(this.orangeBackBtn);
            this.panel1.Controls.Add(this.yellowBackBtn);
            this.panel1.Controls.Add(this.whiteBackColor);
            this.panel1.Controls.Add(this.greenLineBtn);
            this.panel1.Controls.Add(this.purpleLineBtn);
            this.panel1.Controls.Add(this.redLineBtn);
            this.panel1.Controls.Add(this.orangeLineBtn);
            this.panel1.Controls.Add(this.yellowLineBtn);
            this.panel1.Controls.Add(this.whiteLineBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chooseColorLineLbl);
            this.panel1.Controls.Add(this.colorLbl);
            this.panel1.Controls.Add(this.libBtn);
            this.panel1.Controls.Add(this.vuBtn);
            this.panel1.Controls.Add(this.brezAdBtn);
            this.panel1.Controls.Add(this.brezIntBtn);
            this.panel1.Controls.Add(this.brezFloatBtn);
            this.panel1.Controls.Add(this.cdaBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 751);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(3, 656);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 26);
            this.button2.TabIndex = 49;
            this.button2.Text = "Замеры ступенчатости";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(4, 688);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 26);
            this.button1.TabIndex = 48;
            this.button1.Text = "Замеры времени";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(249, 245);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(18, 17);
            this.checkBox6.TabIndex = 47;
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(249, 213);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(18, 17);
            this.checkBox5.TabIndex = 46;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(250, 181);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(18, 17);
            this.checkBox4.TabIndex = 45;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(250, 149);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 44;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(250, 118);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 43;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelBtn.Location = new System.Drawing.Point(3, 720);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(269, 26);
            this.cancelBtn.TabIndex = 41;
            this.cancelBtn.Text = "Очистка экрана";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // drawLbl
            // 
            this.drawLbl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.drawLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawLbl.Location = new System.Drawing.Point(3, 405);
            this.drawLbl.Name = "drawLbl";
            this.drawLbl.Size = new System.Drawing.Size(269, 41);
            this.drawLbl.TabIndex = 40;
            this.drawLbl.Text = "Отрисовка";
            this.drawLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawSpecBtn
            // 
            this.drawSpecBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.drawSpecBtn.Location = new System.Drawing.Point(3, 612);
            this.drawSpecBtn.Name = "drawSpecBtn";
            this.drawSpecBtn.Size = new System.Drawing.Size(269, 26);
            this.drawSpecBtn.TabIndex = 39;
            this.drawSpecBtn.Text = "Отрисовать спектр";
            this.drawSpecBtn.UseVisualStyleBackColor = false;
            this.drawSpecBtn.Click += new System.EventHandler(this.drawSpecBtn_Click);
            // 
            // lengthSpec
            // 
            this.lengthSpec.DecimalPlaces = 1;
            this.lengthSpec.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lengthSpec.Location = new System.Drawing.Point(206, 584);
            this.lengthSpec.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.lengthSpec.Name = "lengthSpec";
            this.lengthSpec.Size = new System.Drawing.Size(66, 22);
            this.lengthSpec.TabIndex = 38;
            // 
            // angleSpec
            // 
            this.angleSpec.Location = new System.Drawing.Point(139, 584);
            this.angleSpec.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.angleSpec.Name = "angleSpec";
            this.angleSpec.Size = new System.Drawing.Size(65, 22);
            this.angleSpec.TabIndex = 37;
            // 
            // yCenter
            // 
            this.yCenter.DecimalPlaces = 1;
            this.yCenter.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.yCenter.Location = new System.Drawing.Point(70, 584);
            this.yCenter.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.yCenter.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.yCenter.Name = "yCenter";
            this.yCenter.Size = new System.Drawing.Size(66, 22);
            this.yCenter.TabIndex = 36;
            // 
            // xCenter
            // 
            this.xCenter.DecimalPlaces = 1;
            this.xCenter.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xCenter.Location = new System.Drawing.Point(3, 584);
            this.xCenter.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.xCenter.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.xCenter.Name = "xCenter";
            this.xCenter.Size = new System.Drawing.Size(65, 22);
            this.xCenter.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(206, 561);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 29);
            this.label7.TabIndex = 34;
            this.label7.Text = "Длина";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(137, 562);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 29);
            this.label8.TabIndex = 33;
            this.label8.Text = "Угол";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(71, 562);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 29);
            this.label9.TabIndex = 32;
            this.label9.Text = "Уц";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 562);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 29);
            this.label10.TabIndex = 31;
            this.label10.Text = "Хц";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawLineBtn
            // 
            this.drawLineBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.drawLineBtn.Location = new System.Drawing.Point(3, 504);
            this.drawLineBtn.Name = "drawLineBtn";
            this.drawLineBtn.Size = new System.Drawing.Size(269, 26);
            this.drawLineBtn.TabIndex = 30;
            this.drawLineBtn.Text = "Отрисовать линию";
            this.drawLineBtn.UseVisualStyleBackColor = false;
            this.drawLineBtn.Click += new System.EventHandler(this.drawLineBtn_Click);
            // 
            // yEnd
            // 
            this.yEnd.DecimalPlaces = 1;
            this.yEnd.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.yEnd.Location = new System.Drawing.Point(206, 476);
            this.yEnd.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.yEnd.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.yEnd.Name = "yEnd";
            this.yEnd.Size = new System.Drawing.Size(66, 22);
            this.yEnd.TabIndex = 29;
            // 
            // xEnd
            // 
            this.xEnd.DecimalPlaces = 1;
            this.xEnd.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xEnd.Location = new System.Drawing.Point(139, 476);
            this.xEnd.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.xEnd.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.xEnd.Name = "xEnd";
            this.xEnd.Size = new System.Drawing.Size(65, 22);
            this.xEnd.TabIndex = 28;
            // 
            // yBeg
            // 
            this.yBeg.DecimalPlaces = 1;
            this.yBeg.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.yBeg.Location = new System.Drawing.Point(70, 476);
            this.yBeg.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.yBeg.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.yBeg.Name = "yBeg";
            this.yBeg.Size = new System.Drawing.Size(66, 22);
            this.yBeg.TabIndex = 27;
            // 
            // xBeg
            // 
            this.xBeg.DecimalPlaces = 1;
            this.xBeg.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xBeg.Location = new System.Drawing.Point(3, 476);
            this.xBeg.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.xBeg.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.xBeg.Name = "xBeg";
            this.xBeg.Size = new System.Drawing.Size(65, 22);
            this.xBeg.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(206, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ук";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(138, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Хк";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(71, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ун";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Хн";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greenBackBtn
            // 
            this.greenBackBtn.BackColor = System.Drawing.Color.Green;
            this.greenBackBtn.Location = new System.Drawing.Point(234, 361);
            this.greenBackBtn.Name = "greenBackBtn";
            this.greenBackBtn.Size = new System.Drawing.Size(30, 29);
            this.greenBackBtn.TabIndex = 21;
            this.greenBackBtn.UseVisualStyleBackColor = false;
            this.greenBackBtn.Click += new System.EventHandler(this.greenBackBtn_Click);
            // 
            // purpleBackBtn
            // 
            this.purpleBackBtn.BackColor = System.Drawing.Color.Purple;
            this.purpleBackBtn.Location = new System.Drawing.Point(206, 361);
            this.purpleBackBtn.Name = "purpleBackBtn";
            this.purpleBackBtn.Size = new System.Drawing.Size(30, 29);
            this.purpleBackBtn.TabIndex = 20;
            this.purpleBackBtn.UseVisualStyleBackColor = false;
            this.purpleBackBtn.Click += new System.EventHandler(this.purpleBackBtn_Click);
            // 
            // redBackBtn
            // 
            this.redBackBtn.BackColor = System.Drawing.Color.Red;
            this.redBackBtn.Location = new System.Drawing.Point(178, 361);
            this.redBackBtn.Name = "redBackBtn";
            this.redBackBtn.Size = new System.Drawing.Size(30, 29);
            this.redBackBtn.TabIndex = 19;
            this.redBackBtn.UseVisualStyleBackColor = false;
            this.redBackBtn.Click += new System.EventHandler(this.redBackBtn_Click);
            // 
            // orangeBackBtn
            // 
            this.orangeBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeBackBtn.Location = new System.Drawing.Point(150, 361);
            this.orangeBackBtn.Name = "orangeBackBtn";
            this.orangeBackBtn.Size = new System.Drawing.Size(30, 29);
            this.orangeBackBtn.TabIndex = 18;
            this.orangeBackBtn.UseVisualStyleBackColor = false;
            this.orangeBackBtn.Click += new System.EventHandler(this.orangeBackBtn_Click);
            // 
            // yellowBackBtn
            // 
            this.yellowBackBtn.BackColor = System.Drawing.Color.Yellow;
            this.yellowBackBtn.Location = new System.Drawing.Point(122, 361);
            this.yellowBackBtn.Name = "yellowBackBtn";
            this.yellowBackBtn.Size = new System.Drawing.Size(30, 29);
            this.yellowBackBtn.TabIndex = 17;
            this.yellowBackBtn.UseVisualStyleBackColor = false;
            this.yellowBackBtn.Click += new System.EventHandler(this.yellowBackBtn_Click);
            // 
            // whiteBackColor
            // 
            this.whiteBackColor.Location = new System.Drawing.Point(94, 361);
            this.whiteBackColor.Name = "whiteBackColor";
            this.whiteBackColor.Size = new System.Drawing.Size(30, 29);
            this.whiteBackColor.TabIndex = 16;
            this.whiteBackColor.UseVisualStyleBackColor = true;
            this.whiteBackColor.Click += new System.EventHandler(this.whiteBackColor_Click);
            // 
            // greenLineBtn
            // 
            this.greenLineBtn.BackColor = System.Drawing.Color.Green;
            this.greenLineBtn.Location = new System.Drawing.Point(234, 332);
            this.greenLineBtn.Name = "greenLineBtn";
            this.greenLineBtn.Size = new System.Drawing.Size(30, 29);
            this.greenLineBtn.TabIndex = 15;
            this.greenLineBtn.UseVisualStyleBackColor = false;
            this.greenLineBtn.Click += new System.EventHandler(this.greenLineBtn_Click);
            // 
            // purpleLineBtn
            // 
            this.purpleLineBtn.BackColor = System.Drawing.Color.Purple;
            this.purpleLineBtn.Location = new System.Drawing.Point(206, 332);
            this.purpleLineBtn.Name = "purpleLineBtn";
            this.purpleLineBtn.Size = new System.Drawing.Size(30, 29);
            this.purpleLineBtn.TabIndex = 14;
            this.purpleLineBtn.UseVisualStyleBackColor = false;
            this.purpleLineBtn.Click += new System.EventHandler(this.purpleLineBtn_Click);
            // 
            // redLineBtn
            // 
            this.redLineBtn.BackColor = System.Drawing.Color.Red;
            this.redLineBtn.Location = new System.Drawing.Point(178, 332);
            this.redLineBtn.Name = "redLineBtn";
            this.redLineBtn.Size = new System.Drawing.Size(30, 29);
            this.redLineBtn.TabIndex = 13;
            this.redLineBtn.UseVisualStyleBackColor = false;
            this.redLineBtn.Click += new System.EventHandler(this.redLineBtn_Click);
            // 
            // orangeLineBtn
            // 
            this.orangeLineBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeLineBtn.Location = new System.Drawing.Point(150, 332);
            this.orangeLineBtn.Name = "orangeLineBtn";
            this.orangeLineBtn.Size = new System.Drawing.Size(30, 29);
            this.orangeLineBtn.TabIndex = 12;
            this.orangeLineBtn.UseVisualStyleBackColor = false;
            this.orangeLineBtn.Click += new System.EventHandler(this.orangeLineBtn_Click);
            // 
            // yellowLineBtn
            // 
            this.yellowLineBtn.BackColor = System.Drawing.Color.Yellow;
            this.yellowLineBtn.Location = new System.Drawing.Point(122, 332);
            this.yellowLineBtn.Name = "yellowLineBtn";
            this.yellowLineBtn.Size = new System.Drawing.Size(30, 29);
            this.yellowLineBtn.TabIndex = 11;
            this.yellowLineBtn.UseVisualStyleBackColor = false;
            this.yellowLineBtn.Click += new System.EventHandler(this.yellowLineBtn_Click);
            // 
            // whiteLineBtn
            // 
            this.whiteLineBtn.Location = new System.Drawing.Point(94, 332);
            this.whiteLineBtn.Name = "whiteLineBtn";
            this.whiteLineBtn.Size = new System.Drawing.Size(30, 29);
            this.whiteLineBtn.TabIndex = 1;
            this.whiteLineBtn.UseVisualStyleBackColor = true;
            this.whiteLineBtn.Click += new System.EventHandler(this.whiteLineBtn_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Цвет фона:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chooseColorLineLbl
            // 
            this.chooseColorLineLbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chooseColorLineLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseColorLineLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseColorLineLbl.Location = new System.Drawing.Point(8, 332);
            this.chooseColorLineLbl.Name = "chooseColorLineLbl";
            this.chooseColorLineLbl.Size = new System.Drawing.Size(93, 29);
            this.chooseColorLineLbl.TabIndex = 9;
            this.chooseColorLineLbl.Text = "Цвет линии:";
            this.chooseColorLineLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorLbl
            // 
            this.colorLbl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.colorLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorLbl.Location = new System.Drawing.Point(3, 280);
            this.colorLbl.Name = "colorLbl";
            this.colorLbl.Size = new System.Drawing.Size(269, 41);
            this.colorLbl.TabIndex = 8;
            this.colorLbl.Text = "Выбор цветов";
            this.colorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // libBtn
            // 
            this.libBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.libBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.libBtn.Location = new System.Drawing.Point(3, 239);
            this.libBtn.Name = "libBtn";
            this.libBtn.Size = new System.Drawing.Size(269, 26);
            this.libBtn.TabIndex = 7;
            this.libBtn.Text = "Библиотечный алгоритм";
            this.libBtn.UseVisualStyleBackColor = false;
            this.libBtn.Click += new System.EventHandler(this.libBtn_Click);
            // 
            // vuBtn
            // 
            this.vuBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.vuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vuBtn.Location = new System.Drawing.Point(3, 207);
            this.vuBtn.Name = "vuBtn";
            this.vuBtn.Size = new System.Drawing.Size(269, 26);
            this.vuBtn.TabIndex = 6;
            this.vuBtn.Text = "Ву";
            this.vuBtn.UseVisualStyleBackColor = false;
            this.vuBtn.Click += new System.EventHandler(this.vuBtn_Click);
            // 
            // brezAdBtn
            // 
            this.brezAdBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.brezAdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brezAdBtn.Location = new System.Drawing.Point(3, 175);
            this.brezAdBtn.Name = "brezAdBtn";
            this.brezAdBtn.Size = new System.Drawing.Size(269, 26);
            this.brezAdBtn.TabIndex = 5;
            this.brezAdBtn.Text = "Брезенхем с устр. ступенчатости";
            this.brezAdBtn.UseVisualStyleBackColor = false;
            this.brezAdBtn.Click += new System.EventHandler(this.brezAdBtn_Click);
            // 
            // brezIntBtn
            // 
            this.brezIntBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.brezIntBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brezIntBtn.Location = new System.Drawing.Point(3, 143);
            this.brezIntBtn.Name = "brezIntBtn";
            this.brezIntBtn.Size = new System.Drawing.Size(269, 26);
            this.brezIntBtn.TabIndex = 4;
            this.brezIntBtn.Text = "целочисленный Брезенхем";
            this.brezIntBtn.UseVisualStyleBackColor = false;
            this.brezIntBtn.Click += new System.EventHandler(this.brezIntBtn_Click);
            // 
            // brezFloatBtn
            // 
            this.brezFloatBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.brezFloatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brezFloatBtn.Location = new System.Drawing.Point(3, 112);
            this.brezFloatBtn.Name = "brezFloatBtn";
            this.brezFloatBtn.Size = new System.Drawing.Size(269, 26);
            this.brezFloatBtn.TabIndex = 3;
            this.brezFloatBtn.Text = "вещественный Брезенхем";
            this.brezFloatBtn.UseVisualStyleBackColor = false;
            this.brezFloatBtn.Click += new System.EventHandler(this.brezFloatBtn_Click);
            // 
            // cdaBtn
            // 
            this.cdaBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cdaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cdaBtn.Location = new System.Drawing.Point(3, 79);
            this.cdaBtn.Name = "cdaBtn";
            this.cdaBtn.Size = new System.Drawing.Size(269, 26);
            this.cdaBtn.TabIndex = 2;
            this.cdaBtn.Text = "ЦДА";
            this.cdaBtn.UseVisualStyleBackColor = false;
            this.cdaBtn.Click += new System.EventHandler(this.cdaBtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Алгоритмы рисования";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(273, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoTask,
            this.infoAuthor});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(65, 26);
            this.menu.Text = "Меню";
            // 
            // infoTask
            // 
            this.infoTask.Name = "infoTask";
            this.infoTask.Size = new System.Drawing.Size(259, 26);
            this.infoTask.Text = "Информация о задаче";
            // 
            // infoAuthor
            // 
            this.infoAuthor.Name = "infoAuthor";
            this.infoAuthor.Size = new System.Drawing.Size(259, 26);
            this.infoAuthor.Text = "Информация об авторе";
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(174, 26);
            this.exit.Text = "Выйти из программы";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(277, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(999, 750);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(251, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 42;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 750);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthSpec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleSpec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xBeg)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem infoTask;
        private System.Windows.Forms.ToolStripMenuItem infoAuthor;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cdaBtn;
        private System.Windows.Forms.Button yellowLineBtn;
        private System.Windows.Forms.Button whiteLineBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label chooseColorLineLbl;
        private System.Windows.Forms.Label colorLbl;
        private System.Windows.Forms.Button libBtn;
        private System.Windows.Forms.Button vuBtn;
        private System.Windows.Forms.Button brezAdBtn;
        private System.Windows.Forms.Button brezIntBtn;
        private System.Windows.Forms.Button brezFloatBtn;
        private System.Windows.Forms.Button greenBackBtn;
        private System.Windows.Forms.Button purpleBackBtn;
        private System.Windows.Forms.Button redBackBtn;
        private System.Windows.Forms.Button orangeBackBtn;
        private System.Windows.Forms.Button yellowBackBtn;
        private System.Windows.Forms.Button whiteBackColor;
        private System.Windows.Forms.Button greenLineBtn;
        private System.Windows.Forms.Button purpleLineBtn;
        private System.Windows.Forms.Button redLineBtn;
        private System.Windows.Forms.Button orangeLineBtn;
        private System.Windows.Forms.NumericUpDown yBeg;
        private System.Windows.Forms.NumericUpDown xBeg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button drawLineBtn;
        private System.Windows.Forms.NumericUpDown yEnd;
        private System.Windows.Forms.NumericUpDown xEnd;
        private System.Windows.Forms.Button drawSpecBtn;
        private System.Windows.Forms.NumericUpDown lengthSpec;
        private System.Windows.Forms.NumericUpDown angleSpec;
        private System.Windows.Forms.NumericUpDown yCenter;
        private System.Windows.Forms.NumericUpDown xCenter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label drawLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Painter.DrawLineFunc drawFunc;
        private List<(PointF, PointF, Color, Painter.DrawLineFunc)> lines;
        private List<(PointF, float, float, Color, Painter.DrawLineFunc)> spectrums;
        private Color backColor = Color.White;
        private Color lineColor = Color.Red;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

