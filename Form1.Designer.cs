namespace WeatherAPP
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            BtnSearch = new Button();
            ConditionLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            LabelSunrise = new Label();
            label5 = new Label();
            LabelSunset = new Label();
            label6 = new Label();
            LabelPressure = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            TempLabel = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(114, 30);
            label1.TabIndex = 0;
            label1.Text = "Weather";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(34, 85);
            label2.Name = "label2";
            label2.Size = new Size(41, 21);
            label2.TabIndex = 3;
            label2.Text = "City";
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(282, 84);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 23);
            BtnSearch.TabIndex = 4;
            BtnSearch.Tag = "BtnSearch";
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += button1_Click;
            // 
            // ConditionLabel
            // 
            ConditionLabel.AutoSize = true;
            ConditionLabel.BackColor = Color.Transparent;
            ConditionLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConditionLabel.ForeColor = SystemColors.ButtonHighlight;
            ConditionLabel.Location = new Point(129, 134);
            ConditionLabel.Name = "ConditionLabel";
            ConditionLabel.Size = new Size(0, 21);
            ConditionLabel.TabIndex = 5;
            ConditionLabel.Click += label3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(129, 155);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 6;
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(25, 233);
            label4.Name = "label4";
            label4.Size = new Size(60, 18);
            label4.TabIndex = 7;
            label4.Text = "Sunrise";
            // 
            // LabelSunrise
            // 
            LabelSunrise.AutoSize = true;
            LabelSunrise.BackColor = Color.Transparent;
            LabelSunrise.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSunrise.ForeColor = SystemColors.ButtonHighlight;
            LabelSunrise.Location = new Point(119, 233);
            LabelSunrise.Name = "LabelSunrise";
            LabelSunrise.Size = new Size(42, 21);
            LabelSunrise.TabIndex = 8;
            LabelSunrise.Text = "N/A";
            LabelSunrise.Click += label5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(25, 257);
            label5.Name = "label5";
            label5.Size = new Size(56, 18);
            label5.TabIndex = 9;
            label5.Text = "Sunset";
            // 
            // LabelSunset
            // 
            LabelSunset.AutoSize = true;
            LabelSunset.BackColor = Color.Transparent;
            LabelSunset.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSunset.ForeColor = SystemColors.ButtonHighlight;
            LabelSunset.Location = new Point(119, 255);
            LabelSunset.Name = "LabelSunset";
            LabelSunset.Size = new Size(42, 21);
            LabelSunset.TabIndex = 10;
            LabelSunset.Text = "N/A";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(595, 158);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 14;
            label6.Text = "N/A";
            label6.Click += label6_Click;
            // 
            // LabelPressure
            // 
            LabelPressure.AutoSize = true;
            LabelPressure.BackColor = Color.Transparent;
            LabelPressure.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic);
            LabelPressure.ForeColor = SystemColors.ButtonHighlight;
            LabelPressure.Location = new Point(486, 161);
            LabelPressure.Name = "LabelPressure";
            LabelPressure.Size = new Size(69, 18);
            LabelPressure.TabIndex = 13;
            LabelPressure.Text = "Pressure";
            LabelPressure.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(486, 255);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(595, 134);
            label7.Name = "label7";
            label7.Size = new Size(42, 21);
            label7.TabIndex = 17;
            label7.Text = "N/A";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(486, 134);
            label8.Name = "label8";
            label8.Size = new Size(97, 18);
            label8.TabIndex = 16;
            label8.Text = "Wind Speed";
            label8.Click += label8_Click;
            // 
            // TempLabel
            // 
            TempLabel.AutoSize = true;
            TempLabel.BackColor = Color.Transparent;
            TempLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TempLabel.ForeColor = SystemColors.ButtonHighlight;
            TempLabel.Location = new Point(25, 203);
            TempLabel.Name = "TempLabel";
            TempLabel.Size = new Size(102, 18);
            TempLabel.TabIndex = 18;
            TempLabel.Text = "Temperature";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(25, 137);
            label9.Name = "label9";
            label9.Size = new Size(81, 18);
            label9.TabIndex = 19;
            label9.Text = "Condition";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(25, 155);
            label10.Name = "label10";
            label10.Size = new Size(93, 18);
            label10.TabIndex = 20;
            label10.Text = "Description";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(986, 534);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(TempLabel);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(LabelPressure);
            Controls.Add(LabelSunset);
            Controls.Add(label5);
            Controls.Add(LabelSunrise);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ConditionLabel);
            Controls.Add(BtnSearch);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Weather Forecast";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button BtnSearch;
        private Label ConditionLabel;
        private Label label3;
        private Label label4;
        private Label LabelSunrise;
        private Label label5;
        private Label LabelSunset;
        private Label label6;
        private Label LabelPressure;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
        private Label TempLabel;
        private Label label9;
        private Label label10;
    }
}
