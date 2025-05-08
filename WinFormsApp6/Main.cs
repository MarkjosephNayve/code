using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp6
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Patient pat = new Patient();
            pat.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Treatment trt = new Treatment();
            trt.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Presciption pres = new Presciption();
            pres.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            User us = new User();
            us.Show();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successfully");
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=schoolmdb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into AppointmentTbl values (@apname,@apservice,@apdate,@aptime)", con);
            cnn.Parameters.AddWithValue("@ApName", textBox1.Text);
            cnn.Parameters.AddWithValue("@ApService", comboBox1.Text);
            cnn.Parameters.AddWithValue("@ApDate", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("@ApTime", comboBox2.Text);
            cnn.ExecuteNonQuery();
            MessageBox.Show("Record Saved Succesfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=schoolmdb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from AppointmentTbl", con);
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=schoolmdb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete AppointmentTbl where apname=@apname", con);
            SqlParameter sqlparameter = cnn.Parameters.AddWithValue("@ApName", textBox1.Text);
            cnn.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Are you sure you want to delete the record? (the record will delete permanently)", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
       

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=schoolmdb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("update AppointmentTbl set apdate=@apdate,aptime=@aptime where apid=@apid", con);
            cnn.Parameters.AddWithValue("@ApId", int.Parse(textBox2.Text));
            cnn.Parameters.AddWithValue("@ApDate", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("@ApTime", comboBox2.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Succesfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}


