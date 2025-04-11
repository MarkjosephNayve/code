namespace WinFormsApp5
{
    partial class Employee
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
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            btndisplay = new Button();
            btnnew = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            btnadd = new Button();
            btnsave = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            lblcount = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(359, 29);
            label1.TabIndex = 1;
            label1.Text = "Employee Information System";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblcount);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(btndisplay);
            groupBox1.Controls.Add(btnnew);
            groupBox1.Controls.Add(btndelete);
            groupBox1.Controls.Add(btnupdate);
            groupBox1.Controls.Add(btnadd);
            groupBox1.Controls.Add(btnsave);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 218);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Information:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(208, 88);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(258, 23);
            dateTimePicker1.TabIndex = 19;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker1.KeyDown += dateTimePicker1_KeyDown;
            // 
            // btndisplay
            // 
            btndisplay.BackColor = SystemColors.InactiveCaption;
            btndisplay.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndisplay.Location = new Point(666, 129);
            btndisplay.Name = "btndisplay";
            btndisplay.Size = new Size(104, 36);
            btndisplay.TabIndex = 18;
            btndisplay.Text = "Display";
            btndisplay.UseVisualStyleBackColor = false;
            btndisplay.Click += btndisplay_Click;
            // 
            // btnnew
            // 
            btnnew.BackColor = SystemColors.InactiveCaption;
            btnnew.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnew.Location = new Point(666, 81);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(104, 36);
            btnnew.TabIndex = 17;
            btnnew.Text = "New";
            btnnew.UseVisualStyleBackColor = false;
            btnnew.Click += btnnew_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = SystemColors.InactiveCaption;
            btndelete.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(666, 36);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(104, 36);
            btndelete.TabIndex = 16;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = SystemColors.InactiveCaption;
            btnupdate.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(536, 128);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(104, 36);
            btnupdate.TabIndex = 15;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnadd
            // 
            btnadd.BackColor = SystemColors.InactiveCaption;
            btnadd.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnadd.Location = new Point(536, 81);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(104, 36);
            btnadd.TabIndex = 14;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // btnsave
            // 
            btnsave.BackColor = SystemColors.InactiveCaption;
            btnsave.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(536, 36);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(104, 36);
            btnsave.TabIndex = 13;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(208, 170);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(258, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(208, 141);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(258, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(208, 114);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(258, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(208, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(208, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 23);
            textBox1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(44, 176);
            label7.Name = "label7";
            label7.Size = new Size(43, 17);
            label7.TabIndex = 5;
            label7.Text = "Salary";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(44, 147);
            label6.Name = "label6";
            label6.Size = new Size(112, 17);
            label6.TabIndex = 4;
            label6.Text = "CompleteAddress";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 120);
            label5.Name = "label5";
            label5.Size = new Size(87, 17);
            label5.TabIndex = 3;
            label5.Text = "EmailAddress";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 94);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 2;
            label4.Text = "DateOfBirth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 68);
            label3.Name = "label3";
            label3.Size = new Size(100, 17);
            label3.TabIndex = 1;
            label3.Text = "EmployeeName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 42);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 0;
            label2.Text = "EmpID";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 280);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 180);
            dataGridView1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(472, 176);
            label8.Name = "label8";
            label8.Size = new Size(162, 24);
            label8.TabIndex = 20;
            label8.Text = "Total Employee:";
            // 
            // lblcount
            // 
            lblcount.AutoSize = true;
            lblcount.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcount.Location = new Point(640, 176);
            lblcount.Name = "lblcount";
            lblcount.Size = new Size(21, 24);
            lblcount.TabIndex = 21;
            lblcount.Text = "0";
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 464);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Employee";
            Text = "Employee";
            Load += Employee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnsave;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btndisplay;
        private Button btnnew;
        private Button btndelete;
        private Button btnupdate;
        private Button btnadd;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label lblcount;
    }
}