namespace T3.View
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
            button1 = new Button();
            groupBox2 = new GroupBox();
            lowestPrice = new TextBox();
            highestPrice = new TextBox();
            lowestVolume = new TextBox();
            highestVolume = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker4 = new DateTimePicker();
            label3 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            dateTimePicker5 = new DateTimePicker();
            dateTimePicker6 = new DateTimePicker();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(6, 6);
            button1.Name = "button1";
            button1.Size = new Size(24, 360);
            button1.TabIndex = 0;
            button1.Text = "|";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lowestPrice);
            groupBox2.Controls.Add(highestPrice);
            groupBox2.Controls.Add(lowestVolume);
            groupBox2.Controls.Add(highestVolume);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(36, 98);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(313, 129);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Volume";
            // 
            // lowestPrice
            // 
            lowestPrice.Location = new Point(6, 99);
            lowestPrice.Name = "lowestPrice";
            lowestPrice.ReadOnly = true;
            lowestPrice.Size = new Size(145, 23);
            lowestPrice.TabIndex = 7;
            // 
            // highestPrice
            // 
            highestPrice.Location = new Point(177, 99);
            highestPrice.Name = "highestPrice";
            highestPrice.ReadOnly = true;
            highestPrice.Size = new Size(130, 23);
            highestPrice.TabIndex = 6;
            // 
            // lowestVolume
            // 
            lowestVolume.Location = new Point(6, 70);
            lowestVolume.Name = "lowestVolume";
            lowestVolume.ReadOnly = true;
            lowestVolume.Size = new Size(145, 23);
            lowestVolume.TabIndex = 5;
            lowestVolume.TextChanged += textBox2_TextChanged;
            // 
            // highestVolume
            // 
            highestVolume.Location = new Point(177, 70);
            highestVolume.Name = "highestVolume";
            highestVolume.ReadOnly = true;
            highestVolume.Size = new Size(130, 23);
            highestVolume.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 52);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Highest";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 52);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Lowest";
            label1.Click += label1_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd.MM.yyyy HH.mm";
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(177, 22);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(130, 23);
            dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH.mm";
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(6, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(145, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "dd.MM.yyyy HH.mm";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(42, 31);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(139, 23);
            dateTimePicker3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(190, 31);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 7;
            label4.Text = "__";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.CustomFormat = "dd.MM.yyyy HH.mm";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.Location = new Point(213, 31);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(136, 23);
            dateTimePicker4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(172, 6);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 8;
            label3.Text = "Range";
            // 
            // button2
            // 
            button2.Location = new Point(159, 71);
            button2.Name = "button2";
            button2.Size = new Size(78, 21);
            button2.TabIndex = 9;
            button2.Text = "Hae";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 250);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(213, 250);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 23);
            textBox2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(233, 232);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 8;
            label5.Text = "Highest Bullish";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(68, 232);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 12;
            label6.Text = "Highest Bearish";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dateTimePicker5);
            groupBox1.Controls.Add(dateTimePicker6);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(36, 279);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 87);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Best Buy/Sell";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(219, 19);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 11;
            label8.Text = "Sell";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 19);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 10;
            label7.Text = "Buy";
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.CustomFormat = "dd.MM.yyyy HH.mm";
            dateTimePicker5.Enabled = false;
            dateTimePicker5.Format = DateTimePickerFormat.Custom;
            dateTimePicker5.Location = new Point(6, 39);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(145, 23);
            dateTimePicker5.TabIndex = 8;
            // 
            // dateTimePicker6
            // 
            dateTimePicker6.CustomFormat = "dd.MM.yyyy HH.mm";
            dateTimePicker6.Enabled = false;
            dateTimePicker6.Format = DateTimePickerFormat.Custom;
            dateTimePicker6.Location = new Point(162, 39);
            dateTimePicker6.Name = "dateTimePicker6";
            dateTimePicker6.Size = new Size(145, 23);
            dateTimePicker6.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(355, 376);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(dateTimePicker4);
            Controls.Add(label4);
            Controls.Add(dateTimePicker3);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.99900000000000011D;
            Padding = new Padding(3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private TextBox lowestVolume;
        private TextBox highestVolume;
        private DateTimePicker dateTimePicker3;
        private Label label4;
        private DateTimePicker dateTimePicker4;
        private TextBox lowestPrice;
        private TextBox highestPrice;
        private Label label3;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimePicker5;
        private DateTimePicker dateTimePicker6;
    }
}
