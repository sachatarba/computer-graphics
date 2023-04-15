using System.Collections.Generic;
using System.Drawing;
using System.Reflection;

namespace lab4
{
    partial class MainForm
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.figureNumber = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ellipseHeightStart = new System.Windows.Forms.NumericUpDown();
            this.ellipseWidthStart = new System.Windows.Forms.NumericUpDown();
            this.ellipseWidthEnd = new System.Windows.Forms.NumericUpDown();
            this.ellipseHeightEnd = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.circleRadiusStart = new System.Windows.Forms.NumericUpDown();
            this.circleRadiusEnd = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.figureStep = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ellipseHeight = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.ellipseWidth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.circleRadius = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.drawLineBtn = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.drawLbl = new System.Windows.Forms.Label();
            this.yCenter = new System.Windows.Forms.NumericUpDown();
            this.xCenter = new System.Windows.Forms.NumericUpDown();
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
            this.brezenhemBtn = new System.Windows.Forms.Button();
            this.midpointBtn = new System.Windows.Forms.Button();
            this.parametricBtn = new System.Windows.Forms.Button();
            this.canonicalBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.infoTask = new System.Windows.Forms.ToolStripMenuItem();
            this.infoAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.figureNumber)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ellipseHeightStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipseWidthStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipseWidthEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipseHeightEnd)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circleRadiusStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleRadiusEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.figureStep)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ellipseHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipseWidth)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circleRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCenter)).BeginInit();
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
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.figureNumber);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.figureStep);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.drawLbl);
            this.panel1.Controls.Add(this.yCenter);
            this.panel1.Controls.Add(this.xCenter);
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
            this.panel1.Controls.Add(this.brezenhemBtn);
            this.panel1.Controls.Add(this.midpointBtn);
            this.panel1.Controls.Add(this.parametricBtn);
            this.panel1.Controls.Add(this.canonicalBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 839);
            this.panel1.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelBtn.Location = new System.Drawing.Point(3, 809);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(269, 26);
            this.cancelBtn.TabIndex = 41;
            this.cancelBtn.Text = "Очистка экрана";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(4, 775);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 28);
            this.button1.TabIndex = 48;
            this.button1.Text = "Замеры времени";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // figureNumber
            // 
            this.figureNumber.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.figureNumber.Location = new System.Drawing.Point(152, 601);
            this.figureNumber.Name = "figureNumber";
            this.figureNumber.Size = new System.Drawing.Size(118, 22);
            this.figureNumber.TabIndex = 55;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.ellipseHeightStart);
            this.groupBox4.Controls.Add(this.ellipseWidthStart);
            this.groupBox4.Controls.Add(this.ellipseWidthEnd);
            this.groupBox4.Controls.Add(this.ellipseHeightEnd);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(139, 627);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(131, 138);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Эллипсы";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(73, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 24);
            this.label13.TabIndex = 57;
            this.label13.Text = "Конец";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(27, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 24);
            this.label10.TabIndex = 56;
            this.label10.Text = "Старт";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ellipseHeightStart
            // 
            this.ellipseHeightStart.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ellipseHeightStart.Location = new System.Drawing.Point(27, 63);
            this.ellipseHeightStart.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ellipseHeightStart.Name = "ellipseHeightStart";
            this.ellipseHeightStart.Size = new System.Drawing.Size(50, 22);
            this.ellipseHeightStart.TabIndex = 51;
            // 
            // ellipseWidthStart
            // 
            this.ellipseWidthStart.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ellipseWidthStart.Location = new System.Drawing.Point(27, 38);
            this.ellipseWidthStart.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ellipseWidthStart.Name = "ellipseWidthStart";
            this.ellipseWidthStart.Size = new System.Drawing.Size(50, 22);
            this.ellipseWidthStart.TabIndex = 28;
            // 
            // ellipseWidthEnd
            // 
            this.ellipseWidthEnd.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ellipseWidthEnd.Location = new System.Drawing.Point(82, 38);
            this.ellipseWidthEnd.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ellipseWidthEnd.Name = "ellipseWidthEnd";
            this.ellipseWidthEnd.Size = new System.Drawing.Size(50, 22);
            this.ellipseWidthEnd.TabIndex = 53;
            // 
            // ellipseHeightEnd
            // 
            this.ellipseHeightEnd.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ellipseHeightEnd.Location = new System.Drawing.Point(82, 63);
            this.ellipseHeightEnd.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ellipseHeightEnd.Name = "ellipseHeightEnd";
            this.ellipseHeightEnd.Size = new System.Drawing.Size(50, 22);
            this.ellipseHeightEnd.TabIndex = 55;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(4, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 26);
            this.button4.TabIndex = 30;
            this.button4.Text = "Отрисовка конц.";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.DrawSetOfEllipses_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(-18, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "Rу";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(-18, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 24);
            this.label8.TabIndex = 50;
            this.label8.Text = "Rx";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.circleRadiusStart);
            this.groupBox3.Controls.Add(this.circleRadiusEnd);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(4, 627);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 138);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Окружности";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-1, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 26);
            this.button3.TabIndex = 30;
            this.button3.Text = "Отрисовка конц.";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.DrawSetOfCircles_Click);
            // 
            // circleRadiusStart
            // 
            this.circleRadiusStart.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.circleRadiusStart.Location = new System.Drawing.Point(34, 38);
            this.circleRadiusStart.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.circleRadiusStart.Name = "circleRadiusStart";
            this.circleRadiusStart.Size = new System.Drawing.Size(65, 22);
            this.circleRadiusStart.TabIndex = 28;
            // 
            // circleRadiusEnd
            // 
            this.circleRadiusEnd.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.circleRadiusEnd.Location = new System.Drawing.Point(34, 63);
            this.circleRadiusEnd.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.circleRadiusEnd.Name = "circleRadiusEnd";
            this.circleRadiusEnd.Size = new System.Drawing.Size(65, 22);
            this.circleRadiusEnd.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(-15, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 24);
            this.label9.TabIndex = 52;
            this.label9.Text = "Rк";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(-15, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 24);
            this.label12.TabIndex = 50;
            this.label12.Text = "Rс";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(147, 574);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 24);
            this.label15.TabIndex = 54;
            this.label15.Text = "Кол-во фигур";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // figureStep
            // 
            this.figureStep.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.figureStep.Location = new System.Drawing.Point(8, 601);
            this.figureStep.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.figureStep.Name = "figureStep";
            this.figureStep.Size = new System.Drawing.Size(111, 22);
            this.figureStep.TabIndex = 53;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(142, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 26);
            this.button2.TabIndex = 53;
            this.button2.Text = "Отрисовать линию";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.DrawEllipse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ellipseHeight);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.ellipseWidth);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(134, 461);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 91);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Эллипс";
            // 
            // ellipseHeight
            // 
            this.ellipseHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ellipseHeight.Location = new System.Drawing.Point(70, 31);
            this.ellipseHeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ellipseHeight.Name = "ellipseHeight";
            this.ellipseHeight.Size = new System.Drawing.Size(66, 22);
            this.ellipseHeight.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(70, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 24);
            this.label11.TabIndex = 52;
            this.label11.Text = "Ry";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ellipseWidth
            // 
            this.ellipseWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ellipseWidth.Location = new System.Drawing.Point(1, 31);
            this.ellipseWidth.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ellipseWidth.Name = "ellipseWidth";
            this.ellipseWidth.Size = new System.Drawing.Size(65, 22);
            this.ellipseWidth.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(2, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 51;
            this.label6.Text = "Rx";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(5, 574);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 24);
            this.label14.TabIndex = 53;
            this.label14.Text = "Шаг изменения";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.circleRadius);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.drawLineBtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(3, 461);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 91);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Окружность";
            // 
            // circleRadius
            // 
            this.circleRadius.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.circleRadius.Location = new System.Drawing.Point(27, 31);
            this.circleRadius.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.circleRadius.Name = "circleRadius";
            this.circleRadius.Size = new System.Drawing.Size(65, 22);
            this.circleRadius.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(29, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 50;
            this.label5.Text = "R";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // drawLineBtn
            // 
            this.drawLineBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.drawLineBtn.Location = new System.Drawing.Point(3, 59);
            this.drawLineBtn.Name = "drawLineBtn";
            this.drawLineBtn.Size = new System.Drawing.Size(123, 26);
            this.drawLineBtn.TabIndex = 30;
            this.drawLineBtn.Text = "Отрисовать линию";
            this.drawLineBtn.UseVisualStyleBackColor = false;
            this.drawLineBtn.Click += new System.EventHandler(this.DrawCircleBtn_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(249, 213);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(18, 17);
            this.checkBox5.TabIndex = 46;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Click += new System.EventHandler(this.CheckBox1_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(250, 181);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(18, 17);
            this.checkBox4.TabIndex = 45;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Click += new System.EventHandler(this.CheckBox1_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(250, 149);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 44;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Click += new System.EventHandler(this.CheckBox1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(250, 118);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 43;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.CheckBox1_Click);
            // 
            // drawLbl
            // 
            this.drawLbl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.drawLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawLbl.Location = new System.Drawing.Point(3, 368);
            this.drawLbl.Name = "drawLbl";
            this.drawLbl.Size = new System.Drawing.Size(269, 41);
            this.drawLbl.TabIndex = 40;
            this.drawLbl.Text = "Отрисовка";
            this.drawLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yCenter
            // 
            this.yCenter.DecimalPlaces = 1;
            this.yCenter.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.yCenter.Location = new System.Drawing.Point(143, 429);
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
            this.yCenter.TabIndex = 27;
            // 
            // xCenter
            // 
            this.xCenter.DecimalPlaces = 1;
            this.xCenter.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xCenter.Location = new System.Drawing.Point(63, 429);
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
            this.xCenter.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(145, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Уц";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(64, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Хц";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greenBackBtn
            // 
            this.greenBackBtn.BackColor = System.Drawing.Color.Green;
            this.greenBackBtn.Location = new System.Drawing.Point(234, 324);
            this.greenBackBtn.Name = "greenBackBtn";
            this.greenBackBtn.Size = new System.Drawing.Size(30, 29);
            this.greenBackBtn.TabIndex = 21;
            this.greenBackBtn.UseVisualStyleBackColor = false;
            this.greenBackBtn.Click += new System.EventHandler(this.GreenBackBtn_Click);
            // 
            // purpleBackBtn
            // 
            this.purpleBackBtn.BackColor = System.Drawing.Color.Purple;
            this.purpleBackBtn.Location = new System.Drawing.Point(206, 324);
            this.purpleBackBtn.Name = "purpleBackBtn";
            this.purpleBackBtn.Size = new System.Drawing.Size(30, 29);
            this.purpleBackBtn.TabIndex = 20;
            this.purpleBackBtn.UseVisualStyleBackColor = false;
            this.purpleBackBtn.Click += new System.EventHandler(this.PurpleBackBtn_Click);
            // 
            // redBackBtn
            // 
            this.redBackBtn.BackColor = System.Drawing.Color.Red;
            this.redBackBtn.Location = new System.Drawing.Point(178, 324);
            this.redBackBtn.Name = "redBackBtn";
            this.redBackBtn.Size = new System.Drawing.Size(30, 29);
            this.redBackBtn.TabIndex = 19;
            this.redBackBtn.UseVisualStyleBackColor = false;
            this.redBackBtn.Click += new System.EventHandler(this.RedBackBtn_Click);
            // 
            // orangeBackBtn
            // 
            this.orangeBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeBackBtn.Location = new System.Drawing.Point(150, 324);
            this.orangeBackBtn.Name = "orangeBackBtn";
            this.orangeBackBtn.Size = new System.Drawing.Size(30, 29);
            this.orangeBackBtn.TabIndex = 18;
            this.orangeBackBtn.UseVisualStyleBackColor = false;
            this.orangeBackBtn.Click += new System.EventHandler(this.OrangeBackBtn_Click);
            // 
            // yellowBackBtn
            // 
            this.yellowBackBtn.BackColor = System.Drawing.Color.Yellow;
            this.yellowBackBtn.Location = new System.Drawing.Point(122, 324);
            this.yellowBackBtn.Name = "yellowBackBtn";
            this.yellowBackBtn.Size = new System.Drawing.Size(30, 29);
            this.yellowBackBtn.TabIndex = 17;
            this.yellowBackBtn.UseVisualStyleBackColor = false;
            this.yellowBackBtn.Click += new System.EventHandler(this.YellowBackBtn_Click);
            // 
            // whiteBackColor
            // 
            this.whiteBackColor.Location = new System.Drawing.Point(94, 324);
            this.whiteBackColor.Name = "whiteBackColor";
            this.whiteBackColor.Size = new System.Drawing.Size(30, 29);
            this.whiteBackColor.TabIndex = 16;
            this.whiteBackColor.UseVisualStyleBackColor = true;
            this.whiteBackColor.Click += new System.EventHandler(this.WhiteBackColor_Click);
            // 
            // greenLineBtn
            // 
            this.greenLineBtn.BackColor = System.Drawing.Color.Green;
            this.greenLineBtn.Location = new System.Drawing.Point(234, 295);
            this.greenLineBtn.Name = "greenLineBtn";
            this.greenLineBtn.Size = new System.Drawing.Size(30, 29);
            this.greenLineBtn.TabIndex = 15;
            this.greenLineBtn.UseVisualStyleBackColor = false;
            this.greenLineBtn.Click += new System.EventHandler(this.GreenLineBtn_Click);
            // 
            // purpleLineBtn
            // 
            this.purpleLineBtn.BackColor = System.Drawing.Color.Purple;
            this.purpleLineBtn.Location = new System.Drawing.Point(206, 295);
            this.purpleLineBtn.Name = "purpleLineBtn";
            this.purpleLineBtn.Size = new System.Drawing.Size(30, 29);
            this.purpleLineBtn.TabIndex = 14;
            this.purpleLineBtn.UseVisualStyleBackColor = false;
            this.purpleLineBtn.Click += new System.EventHandler(this.PurpleLineBtn_Click);
            // 
            // redLineBtn
            // 
            this.redLineBtn.BackColor = System.Drawing.Color.Red;
            this.redLineBtn.Location = new System.Drawing.Point(178, 295);
            this.redLineBtn.Name = "redLineBtn";
            this.redLineBtn.Size = new System.Drawing.Size(30, 29);
            this.redLineBtn.TabIndex = 13;
            this.redLineBtn.UseVisualStyleBackColor = false;
            this.redLineBtn.Click += new System.EventHandler(this.RedLineBtn_Click);
            // 
            // orangeLineBtn
            // 
            this.orangeLineBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeLineBtn.Location = new System.Drawing.Point(150, 295);
            this.orangeLineBtn.Name = "orangeLineBtn";
            this.orangeLineBtn.Size = new System.Drawing.Size(30, 29);
            this.orangeLineBtn.TabIndex = 12;
            this.orangeLineBtn.UseVisualStyleBackColor = false;
            this.orangeLineBtn.Click += new System.EventHandler(this.OrangeLineBtn_Click);
            // 
            // yellowLineBtn
            // 
            this.yellowLineBtn.BackColor = System.Drawing.Color.Yellow;
            this.yellowLineBtn.Location = new System.Drawing.Point(122, 295);
            this.yellowLineBtn.Name = "yellowLineBtn";
            this.yellowLineBtn.Size = new System.Drawing.Size(30, 29);
            this.yellowLineBtn.TabIndex = 11;
            this.yellowLineBtn.UseVisualStyleBackColor = false;
            this.yellowLineBtn.Click += new System.EventHandler(this.YellowLineBtn_Click);
            // 
            // whiteLineBtn
            // 
            this.whiteLineBtn.Location = new System.Drawing.Point(94, 295);
            this.whiteLineBtn.Name = "whiteLineBtn";
            this.whiteLineBtn.Size = new System.Drawing.Size(30, 29);
            this.whiteLineBtn.TabIndex = 1;
            this.whiteLineBtn.UseVisualStyleBackColor = true;
            this.whiteLineBtn.Click += new System.EventHandler(this.WhiteLineBtn_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 324);
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
            this.chooseColorLineLbl.Location = new System.Drawing.Point(8, 295);
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
            this.colorLbl.Location = new System.Drawing.Point(3, 243);
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
            this.libBtn.Location = new System.Drawing.Point(3, 207);
            this.libBtn.Name = "libBtn";
            this.libBtn.Size = new System.Drawing.Size(269, 26);
            this.libBtn.TabIndex = 6;
            this.libBtn.Text = "Библиотечная фукнция";
            this.libBtn.UseVisualStyleBackColor = false;
            this.libBtn.Click += new System.EventHandler(this.LibBtn_Click);
            // 
            // brezenhemBtn
            // 
            this.brezenhemBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.brezenhemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brezenhemBtn.Location = new System.Drawing.Point(3, 175);
            this.brezenhemBtn.Name = "brezenhemBtn";
            this.brezenhemBtn.Size = new System.Drawing.Size(269, 26);
            this.brezenhemBtn.TabIndex = 5;
            this.brezenhemBtn.Text = "Алгоритм Брезенхема";
            this.brezenhemBtn.UseVisualStyleBackColor = false;
            this.brezenhemBtn.Click += new System.EventHandler(this.BrezenhemBtn_Click);
            // 
            // midpointBtn
            // 
            this.midpointBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.midpointBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.midpointBtn.Location = new System.Drawing.Point(3, 143);
            this.midpointBtn.Name = "midpointBtn";
            this.midpointBtn.Size = new System.Drawing.Size(269, 26);
            this.midpointBtn.TabIndex = 4;
            this.midpointBtn.Text = "Алгоритм средней точки";
            this.midpointBtn.UseVisualStyleBackColor = false;
            // 
            // parametricBtn
            // 
            this.parametricBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.parametricBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parametricBtn.Location = new System.Drawing.Point(3, 112);
            this.parametricBtn.Name = "parametricBtn";
            this.parametricBtn.Size = new System.Drawing.Size(269, 26);
            this.parametricBtn.TabIndex = 3;
            this.parametricBtn.Text = "Параметрическое уравнение";
            this.parametricBtn.UseVisualStyleBackColor = false;
            // 
            // canonicalBtn
            // 
            this.canonicalBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.canonicalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.canonicalBtn.Location = new System.Drawing.Point(3, 79);
            this.canonicalBtn.Name = "canonicalBtn";
            this.canonicalBtn.Size = new System.Drawing.Size(269, 26);
            this.canonicalBtn.TabIndex = 2;
            this.canonicalBtn.Text = "Каноническое уравнение";
            this.canonicalBtn.UseVisualStyleBackColor = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(273, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoTask,
            this.infoAuthor});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(65, 24);
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
            this.exit.Size = new System.Drawing.Size(174, 24);
            this.exit.Text = "Выйти из программы";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(277, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(999, 838);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(251, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 42;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.CheckBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 838);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.figureNumber)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ellipseHeightStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipseWidthStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipseWidthEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipseHeightEnd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circleRadiusStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleRadiusEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.figureStep)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ellipseHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipseWidth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circleRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCenter)).EndInit();
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
        private System.Windows.Forms.Button canonicalBtn;
        private System.Windows.Forms.Button yellowLineBtn;
        private System.Windows.Forms.Button whiteLineBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label chooseColorLineLbl;
        private System.Windows.Forms.Label colorLbl;
        private System.Windows.Forms.Button libBtn;
        private System.Windows.Forms.Button brezenhemBtn;
        private System.Windows.Forms.Button midpointBtn;
        private System.Windows.Forms.Button parametricBtn;
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
        private System.Windows.Forms.NumericUpDown yCenter;
        private System.Windows.Forms.NumericUpDown xCenter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button drawLineBtn;
        private System.Windows.Forms.NumericUpDown ellipseHeight;
        private System.Windows.Forms.NumericUpDown circleRadius;
        private System.Windows.Forms.Label drawLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Painter.DrawEllipseFunc drawCircleFunc;
        private Painter.DrawEllipseFunc drawEllipseFunc;
        private List<IDrawable> drawObjects;
        //private List<(PointF, PointF, Color, Painter.DrawLineFunc)> lines;
        //private List<(PointF, float, float, Color, Painter.DrawLineFunc)> spectrums;
        private Color backColor = Color.White;
        private Color lineColor = Color.Black;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown ellipseWidth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown ellipseHeightStart;
        private System.Windows.Forms.NumericUpDown ellipseWidthStart;
        private System.Windows.Forms.NumericUpDown ellipseWidthEnd;
        private System.Windows.Forms.NumericUpDown ellipseHeightEnd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown circleRadiusStart;
        private System.Windows.Forms.NumericUpDown circleRadiusEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown figureNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown figureStep;
        private System.Windows.Forms.Label label14;
    }
}