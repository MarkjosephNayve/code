namespace WinFormsApp6
{
    partial class Patient
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            richTextBox2 = new RichTextBox();
            label14 = new Label();
            richTextBox1 = new RichTextBox();
            label13 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label12 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            linkLabel1 = new LinkLabel();
            dataGridView1 = new DataGridView();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(richTextBox2);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(203, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(592, 197);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient";
            // 
            // button2
            // 
            button2.BackColor = Color.Violet;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(306, 156);
            button2.Name = "button2";
            button2.Size = new Size(112, 36);
            button2.TabIndex = 22;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(118, 111);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(166, 44);
            richTextBox2.TabIndex = 21;
            richTextBox2.Text = "";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.Control;
            label14.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(3, 110);
            label14.Name = "label14";
            label14.Size = new Size(74, 21);
            label14.TabIndex = 20;
            label14.Text = "Address";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(423, 98);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(150, 71);
            richTextBox1.TabIndex = 19;
            richTextBox1.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(306, 98);
            label13.Name = "label13";
            label13.Size = new Size(78, 21);
            label13.TabIndex = 18;
            label13.Text = "Allergies";
            // 
            // button1
            // 
            button1.BackColor = Color.Violet;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(306, 119);
            button1.Name = "button1";
            button1.Size = new Size(112, 36);
            button1.TabIndex = 17;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboBox1.Location = new Point(423, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 23);
            comboBox1.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.Control;
            label12.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(306, 69);
            label12.Name = "label12";
            label12.Size = new Size(39, 21);
            label12.TabIndex = 15;
            label12.Text = "Sex";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 23);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Control;
            label11.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(306, 40);
            label11.Name = "label11";
            label11.Size = new Size(108, 21);
            label11.TabIndex = 10;
            label11.Text = "Date of birth";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(423, 41);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(150, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Control;
            label10.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(3, 69);
            label10.Name = "label10";
            label10.Size = new Size(74, 21);
            label10.TabIndex = 7;
            label10.Text = "Phone #";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(3, 27);
            label9.Name = "label9";
            label9.Size = new Size(56, 21);
            label9.TabIndex = 5;
            label9.Text = "Name";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(402, 209);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(185, 21);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Filter By Patient name";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(203, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(592, 173);
            dataGridView1.TabIndex = 5;
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
            panel1.TabIndex = 6;
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
            label8.Click += label8_Click_2;
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
            label6.Click += label6_Click_2;
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
            label5.Click += label5_Click_1;
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Violet;
            label2.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(52, 25);
            label2.Name = "label2";
            label2.Size = new Size(60, 16);
            label2.TabIndex = 3;
            label2.Text = "PATIENT";
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
            // Patient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 406);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(linkLabel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Patient";
            Text = "Patient";
            Load += Patient_Load;
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
        private GroupBox groupBox1;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private Label label9;
        private ComboBox comboBox1;
        private Label label12;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label13;
        private Button button1;
        private RichTextBox richTextBox1;
        private LinkLabel linkLabel1;
        private DataGridView dataGridView1;
        private RichTextBox richTextBox2;
        private Label label14;
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