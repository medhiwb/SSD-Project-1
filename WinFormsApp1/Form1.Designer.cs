﻿namespace WinFormsApp1
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
            label1 = new Label();
            tickerSelectionBox = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            rbuttonYearly = new RadioButton();
            rbuttonMonthly = new RadioButton();
            rbuttonDaily = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            getInfoButton = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(55, 35);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Ticker Selection";
            label1.Click += label1_Click;
            // 
            // tickerSelectionBox
            // 
            tickerSelectionBox.AllowDrop = true;
            tickerSelectionBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tickerSelectionBox.FormattingEnabled = true;
            tickerSelectionBox.Items.AddRange(new object[] { "ABT", "ACN", "ADBE", "IBM", "LUV", "MSFT", "NVDA", "ORCL", "ORLY", "WMT" });
            tickerSelectionBox.Location = new Point(56, 53);
            tickerSelectionBox.Name = "tickerSelectionBox";
            tickerSelectionBox.Size = new Size(121, 23);
            tickerSelectionBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(208, 35);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Interval";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(rbuttonYearly);
            panel1.Controls.Add(rbuttonMonthly);
            panel1.Controls.Add(rbuttonDaily);
            panel1.Location = new Point(208, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 34);
            panel1.TabIndex = 3;
            // 
            // rbuttonYearly
            // 
            rbuttonYearly.AutoSize = true;
            rbuttonYearly.Location = new Point(136, 4);
            rbuttonYearly.Name = "rbuttonYearly";
            rbuttonYearly.Size = new Size(56, 19);
            rbuttonYearly.TabIndex = 0;
            rbuttonYearly.TabStop = true;
            rbuttonYearly.Text = "Yearly";
            rbuttonYearly.UseVisualStyleBackColor = true;
            // 
            // rbuttonMonthly
            // 
            rbuttonMonthly.AutoSize = true;
            rbuttonMonthly.Location = new Point(60, 4);
            rbuttonMonthly.Name = "rbuttonMonthly";
            rbuttonMonthly.Size = new Size(70, 19);
            rbuttonMonthly.TabIndex = 0;
            rbuttonMonthly.TabStop = true;
            rbuttonMonthly.Text = "Monthly";
            rbuttonMonthly.UseVisualStyleBackColor = true;
            // 
            // rbuttonDaily
            // 
            rbuttonDaily.AutoSize = true;
            rbuttonDaily.Location = new Point(3, 4);
            rbuttonDaily.Name = "rbuttonDaily";
            rbuttonDaily.Size = new Size(51, 19);
            rbuttonDaily.TabIndex = 0;
            rbuttonDaily.TabStop = true;
            rbuttonDaily.Text = "Daily";
            rbuttonDaily.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 28);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "Start";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 55);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 7;
            label5.Text = "End";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(55, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 100);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Date Range";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(95, 51);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(95, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // getInfoButton
            // 
            getInfoButton.Location = new Point(187, 199);
            getInfoButton.Name = "getInfoButton";
            getInfoButton.Size = new Size(75, 23);
            getInfoButton.TabIndex = 9;
            getInfoButton.Text = "raassssclattt";
            getInfoButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 450);
            Controls.Add(getInfoButton);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(tickerSelectionBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox tickerSelectionBox;
        private Label label2;
        private Panel panel1;
        private RadioButton rbuttonYearly;
        private RadioButton rbuttonMonthly;
        private RadioButton rbuttonDaily;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button getInfoButton;
    }
}