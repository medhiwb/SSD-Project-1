namespace WinFormsApp1
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
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            endTimePicker = new DateTimePicker();
            startTimePicker = new DateTimePicker();
            dataGridView1 = new DataGridView();
            getFileButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 47);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 32);
            label4.TabIndex = 6;
            label4.Text = "Start";
            //label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 98);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 32);
            label5.TabIndex = 7;
            label5.Text = "End";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(endTimePicker);
            groupBox1.Controls.Add(startTimePicker);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(15, 36);
            groupBox1.Margin = new Padding(6, 6, 6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 6, 6, 6);
            groupBox1.Size = new Size(491, 213);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Date Range";
            // 
            // endTimePicker
            // 
            endTimePicker.Location = new Point(86, 98);
            endTimePicker.Margin = new Padding(6, 6, 6, 6);
            endTimePicker.Name = "endTimePicker";
            endTimePicker.Size = new Size(368, 39);
            endTimePicker.TabIndex = 8;
            // 
            // startTimePicker
            // 
            startTimePicker.Location = new Point(86, 47);
            startTimePicker.Margin = new Padding(6, 6, 6, 6);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.Size = new Size(368, 39);
            startTimePicker.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(540, 50);
            dataGridView1.Margin = new Padding(6, 6, 6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(871, 367);
            dataGridView1.TabIndex = 10;
            // 
            // getFileButton
            // 
            getFileButton.Location = new Point(27, 261);
            getFileButton.Margin = new Padding(6, 6, 6, 6);
            getFileButton.Name = "getFileButton";
            getFileButton.Size = new Size(139, 49);
            getFileButton.TabIndex = 11;
            getFileButton.Text = "Browse";
            getFileButton.UseVisualStyleBackColor = true;
            getFileButton.Click += getFileButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1626, 960);
            Controls.Add(getFileButton);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private DateTimePicker startTimePicker;
        private DateTimePicker endTimePicker;
        private DataGridView dataGridView1;
        private Button getFileButton;
    }
}