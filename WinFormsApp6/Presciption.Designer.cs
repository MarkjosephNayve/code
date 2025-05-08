namespace WinFormsApp6
{
    partial class Presciption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label9 = new Label();
            label10 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            richTextBox2 = new RichTextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            textBox3 = new TextBox();
            label14 = new Label();
            dataGridView1 = new DataGridView();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(6, 24);
            label9.Name = "label9";
            label9.Size = new Size(56, 21);
            label9.TabIndex = 5;
            label9.Text = "Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Control;
            label10.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(6, 99);
            label10.Name = "label10";
            label10.Size = new Size(82, 21);
            label10.TabIndex = 7;
            label10.Text = "Medicine";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.Violet;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(290, 155);
            button1.Name = "button1";
            button1.Size = new Size(126, 38);
            button1.TabIndex = 17;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(118, 99);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(166, 71);
            richTextBox2.TabIndex = 20;
            richTextBox2.Text = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(426, 25);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 23);
            textBox2.TabIndex = 21;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dental Cleanings (Prophylaxis)", "Fillings", "Tooth Extractions", "Root Canal Therapy", "Dental Crowns and Bridges", "Teeth Whitening", "Orthodontics (Braces and Aligners)", "Dental Implants ", "Pediatric Dentistry", "Periodontal Treatment" });
            comboBox1.Location = new Point(118, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 23);
            comboBox1.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.Control;
            label12.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(6, 56);
            label12.Name = "label12";
            label12.Size = new Size(89, 21);
            label12.TabIndex = 23;
            label12.Text = "Treatment";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(338, 27);
            label13.Name = "label13";
            label13.Size = new Size(45, 21);
            label13.TabIndex = 25;
            label13.Text = "Cost";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(richTextBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(206, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(592, 196);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Presciption";
            // 
            // button2
            // 
            button2.BackColor = Color.Violet;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(426, 155);
            button2.Name = "button2";
            button2.Size = new Size(126, 38);
            button2.TabIndex = 28;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(426, 71);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(166, 23);
            textBox3.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.Control;
            label14.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(338, 71);
            label14.Name = "label14";
            label14.Size = new Size(77, 21);
            label14.TabIndex = 26;
            label14.Text = "Quantity";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(206, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(592, 173);
            dataGridView1.TabIndex = 7;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(437, 208);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(185, 21);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Filter By Patient name";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Violet;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 406);
            panel1.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Violet;
            label8.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(52, 267);
            label8.Name = "label8";
            label8.Size = new Size(82, 27);
            label8.TabIndex = 6;
            label8.Text = "Logout";
            label8.Click += label8_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Violet;
            label6.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(52, 219);
            label6.Name = "label6";
            label6.Size = new Size(143, 27);
            label6.TabIndex = 6;
            label6.Text = "Appointment";
            label6.Click += label6_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Violet;
            label5.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(52, 170);
            label5.Name = "label5";
            label5.Size = new Size(128, 27);
            label5.TabIndex = 6;
            label5.Text = "Presciption";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Violet;
            label4.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(52, 124);
            label4.Name = "label4";
            label4.Size = new Size(116, 27);
            label4.TabIndex = 5;
            label4.Text = "Treatment";
            label4.Click += label4_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Violet;
            label3.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(52, 80);
            label3.Name = "label3";
            label3.Size = new Size(86, 27);
            label3.TabIndex = 4;
            label3.Text = "Patient";
            label3.Click += label3_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Violet;
            label2.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(52, 25);
            label2.Name = "label2";
            label2.Size = new Size(98, 16);
            label2.TabIndex = 3;
            label2.Text = "PRESCRIPTION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Violet;
            label1.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 16);
            label1.TabIndex = 2;
            label1.Text = "DELUX DENTAL CLINIC";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.images_Photoroom__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 57);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Presciption
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 406);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(linkLabel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Presciption";
            Text = "Treatment";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Label label10;
        private TextBox textBox1;
        private Button button1;
        private RichTextBox richTextBox2;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label12;
        private Label label13;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private Label label14;
        private DataGridView dataGridView1;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button2;
    }
}