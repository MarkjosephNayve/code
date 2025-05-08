using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp6
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Treatment trt = new Treatment();
            trt.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Presciption pres = new Presciption();
            pres.Show();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            User us = new User();
            us.Show();
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successfully", "OK");
            Form1 frm = new Form1();
            frm.Show();
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=schoolmdb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into PatientTbl values (@patname,@patphone,@Pataddress,@patdob,@patgender,@patallergies)", con);
            cnn.Parameters.AddWithValue("@PatName", textBox1.Text);
            cnn.Parameters.AddWithValue("@PatPhone", textBox2.Text);
            cnn.Parameters.AddWithValue("@PatAddress", richTextBox2.Text);
            cnn.Parameters.AddWithValue("@PatDob", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("@PatGender", comboBox1.Text);
            cnn.Parameters.AddWithValue("@PatAllergies", richTextBox1.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Succesfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=schoolmdb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from PatientTbl", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if (dataGridView1.Visible)
            {
                // Hide the DataGridView
                dataGridView1.Visible = false;
            }
            else
            {
                // Show the DataGridView
                dataGridView1.Visible = true;
            }
        }



        private void label6_Click_2(object sender, EventArgs e)
        {
            Main mnn = new Main();
            mnn.Show();
            this.Close();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Treatment trt = new Treatment();
            trt.Show();
            this.Close();

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Presciption pres = new Presciption();
            pres.Show();
            this.Close();
        }

        private void label8_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successfully", "OK");
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=schoolmdb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete PatientTbl where patname=@patname", con);
            cnn.Parameters.AddWithValue("@PatName", textBox1.Text);
            cnn.Parameters.AddWithValue("@PatDob", dateTimePicker1.Value);

            cnn.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Are you sure you want to delete the record? (the record will delete permanently)", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }


        private void button3_Click_2(object sender, EventArgs e)
        {
            
        }
    }
}
