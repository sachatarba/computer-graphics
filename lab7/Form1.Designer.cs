using System.Collections.Generic;
using System.Drawing;

namespace lab7
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.solveTaskBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.painRectBtn = new System.Windows.Forms.Button();
            this.yRectRightDown = new System.Windows.Forms.NumericUpDown();
            this.xRectRightDown = new System.Windows.Forms.NumericUpDown();
            this.yRectLeftUp = new System.Windows.Forms.NumericUpDown();
            this.xRectLeftUp = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.painSegmentBtn = new System.Windows.Forms.Button();
            this.ySegmentEnd = new System.Windows.Forms.NumericUpDown();
            this.xSegmentEnd = new System.Windows.Forms.NumericUpDown();
            this.ySegmentStart = new System.Windows.Forms.NumericUpDown();
            this.xSegmentStart = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resColorBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rectColorBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.segmentColorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yRectRightDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRectRightDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yRectLeftUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRectLeftUp)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ySegmentEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSegmentEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySegmentStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSegmentStart)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(238, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(914, 667);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.solveTaskBtn);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 667);
            this.panel1.TabIndex = 1;
            // 
            // solveTaskBtn
            // 
            this.solveTaskBtn.Location = new System.Drawing.Point(35, 590);
            this.solveTaskBtn.Name = "solveTaskBtn";
            this.solveTaskBtn.Size = new System.Drawing.Size(164, 25);
            this.solveTaskBtn.TabIndex = 11;
            this.solveTaskBtn.Text = "Отсечь";
            this.solveTaskBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox5.Controls.Add(this.painRectBtn);
            this.groupBox5.Controls.Add(this.yRectRightDown);
            this.groupBox5.Controls.Add(this.xRectRightDown);
            this.groupBox5.Controls.Add(this.yRectLeftUp);
            this.groupBox5.Controls.Add(this.xRectLeftUp);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(5, 434);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(230, 107);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Построение отсекателя";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // painRectBtn
            // 
            this.painRectBtn.Location = new System.Drawing.Point(30, 79);
            this.painRectBtn.Name = "painRectBtn";
            this.painRectBtn.Size = new System.Drawing.Size(164, 25);
            this.painRectBtn.TabIndex = 10;
            this.painRectBtn.Text = "Построить отсекатель";
            this.painRectBtn.UseVisualStyleBackColor = true;
            // 
            // yRectRightDown
            // 
            this.yRectRightDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.yRectRightDown.Location = new System.Drawing.Point(179, 47);
            this.yRectRightDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.yRectRightDown.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.yRectRightDown.Name = "yRectRightDown";
            this.yRectRightDown.Size = new System.Drawing.Size(52, 22);
            this.yRectRightDown.TabIndex = 9;
            // 
            // xRectRightDown
            // 
            this.xRectRightDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xRectRightDown.Location = new System.Drawing.Point(122, 48);
            this.xRectRightDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.xRectRightDown.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.xRectRightDown.Name = "xRectRightDown";
            this.xRectRightDown.Size = new System.Drawing.Size(52, 22);
            this.xRectRightDown.TabIndex = 8;
            this.xRectRightDown.ValueChanged += new System.EventHandler(this.xRectRightDown_ValueChanged);
            // 
            // yRectLeftUp
            // 
            this.yRectLeftUp.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.yRectLeftUp.Location = new System.Drawing.Point(64, 49);
            this.yRectLeftUp.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.yRectLeftUp.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.yRectLeftUp.Name = "yRectLeftUp";
            this.yRectLeftUp.Size = new System.Drawing.Size(52, 22);
            this.yRectLeftUp.TabIndex = 7;
            // 
            // xRectLeftUp
            // 
            this.xRectLeftUp.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xRectLeftUp.Location = new System.Drawing.Point(6, 50);
            this.xRectLeftUp.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.xRectLeftUp.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.xRectLeftUp.Name = "xRectLeftUp";
            this.xRectLeftUp.Size = new System.Drawing.Size(52, 22);
            this.xRectLeftUp.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(190, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Yпн";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(135, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Xпн";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(76, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Yлв";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(18, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Xлв";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.painSegmentBtn);
            this.groupBox4.Controls.Add(this.ySegmentEnd);
            this.groupBox4.Controls.Add(this.xSegmentEnd);
            this.groupBox4.Controls.Add(this.ySegmentStart);
            this.groupBox4.Controls.Add(this.xSegmentStart);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(3, 303);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 108);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Построение отрезка";
            // 
            // painSegmentBtn
            // 
            this.painSegmentBtn.Location = new System.Drawing.Point(32, 81);
            this.painSegmentBtn.Name = "painSegmentBtn";
            this.painSegmentBtn.Size = new System.Drawing.Size(164, 24);
            this.painSegmentBtn.TabIndex = 3;
            this.painSegmentBtn.Text = "Построить отрезок";
            this.painSegmentBtn.UseVisualStyleBackColor = true;
            this.painSegmentBtn.Click += new System.EventHandler(this.PainSegmentBtn_Click);
            // 
            // ySegmentEnd
            // 
            this.ySegmentEnd.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ySegmentEnd.Location = new System.Drawing.Point(179, 47);
            this.ySegmentEnd.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ySegmentEnd.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.ySegmentEnd.Name = "ySegmentEnd";
            this.ySegmentEnd.Size = new System.Drawing.Size(52, 22);
            this.ySegmentEnd.TabIndex = 9;
            // 
            // xSegmentEnd
            // 
            this.xSegmentEnd.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xSegmentEnd.Location = new System.Drawing.Point(122, 48);
            this.xSegmentEnd.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.xSegmentEnd.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.xSegmentEnd.Name = "xSegmentEnd";
            this.xSegmentEnd.Size = new System.Drawing.Size(52, 22);
            this.xSegmentEnd.TabIndex = 8;
            // 
            // ySegmentStart
            // 
            this.ySegmentStart.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ySegmentStart.Location = new System.Drawing.Point(64, 49);
            this.ySegmentStart.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ySegmentStart.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.ySegmentStart.Name = "ySegmentStart";
            this.ySegmentStart.Size = new System.Drawing.Size(52, 22);
            this.ySegmentStart.TabIndex = 7;
            // 
            // xSegmentStart
            // 
            this.xSegmentStart.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xSegmentStart.Location = new System.Drawing.Point(6, 50);
            this.xSegmentStart.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.xSegmentStart.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.xSegmentStart.Name = "xSegmentStart";
            this.xSegmentStart.Size = new System.Drawing.Size(52, 22);
            this.xSegmentStart.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(190, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Yк";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(135, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Xк";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(76, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Yн";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Xн";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.resColorBtn);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(3, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 73);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Цвет отcеченных отрезков";
            // 
            // resColorBtn
            // 
            this.resColorBtn.BackColor = System.Drawing.Color.Red;
            this.resColorBtn.Location = new System.Drawing.Point(119, 28);
            this.resColorBtn.Name = "resColorBtn";
            this.resColorBtn.Size = new System.Drawing.Size(101, 23);
            this.resColorBtn.TabIndex = 1;
            this.resColorBtn.UseVisualStyleBackColor = false;
            this.resColorBtn.Click += new System.EventHandler(this.resColorBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Выбор цвета:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.rectColorBtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(3, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 73);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвет отсекателя";
            // 
            // rectColorBtn
            // 
            this.rectColorBtn.BackColor = System.Drawing.Color.Blue;
            this.rectColorBtn.Location = new System.Drawing.Point(119, 28);
            this.rectColorBtn.Name = "rectColorBtn";
            this.rectColorBtn.Size = new System.Drawing.Size(101, 23);
            this.rectColorBtn.TabIndex = 1;
            this.rectColorBtn.UseVisualStyleBackColor = false;
            this.rectColorBtn.Click += new System.EventHandler(this.rectColorBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выбор цвета:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.segmentColorBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цвет отрезка";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // segmentColorBtn
            // 
            this.segmentColorBtn.BackColor = System.Drawing.Color.Black;
            this.segmentColorBtn.Location = new System.Drawing.Point(119, 28);
            this.segmentColorBtn.Name = "segmentColorBtn";
            this.segmentColorBtn.Size = new System.Drawing.Size(101, 23);
            this.segmentColorBtn.TabIndex = 1;
            this.segmentColorBtn.UseVisualStyleBackColor = false;
            this.segmentColorBtn.Click += new System.EventHandler(this.segmentColorBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбор цвета:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 668);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yRectRightDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRectRightDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yRectLeftUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRectLeftUp)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ySegmentEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSegmentEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySegmentStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSegmentStart)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button segmentColorBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown yRectRightDown;
        private System.Windows.Forms.NumericUpDown xRectRightDown;
        private System.Windows.Forms.NumericUpDown yRectLeftUp;
        private System.Windows.Forms.NumericUpDown xRectLeftUp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown ySegmentEnd;
        private System.Windows.Forms.NumericUpDown xSegmentEnd;
        private System.Windows.Forms.NumericUpDown ySegmentStart;
        private System.Windows.Forms.NumericUpDown xSegmentStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button resColorBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button rectColorBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button painRectBtn;
        private System.Windows.Forms.Button painSegmentBtn;
        private System.Windows.Forms.Button solveTaskBtn;
        private Color segmentColor;
        private Color rectColor;
        private Color resColor;
        private List<(Point, Point, Color)> segments;
        private List<(Point, Point, Color)> rects;
        private List<(Point, Point, Color)> resSegments;
    }
}

