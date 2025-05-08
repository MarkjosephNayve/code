using System;
using System.CodeDom;
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
    public partial class Treatment : Form
    {
        public Treatment()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Patient pat = new Patient();
            pat.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Presciption pres = new Presciption();
            pres.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            User us = new User();
            us.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successfully");
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=schoolmdb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into TreatmentTbl values (@treatname,@treatCost,@treatdesc)", con);
            cnn.Parameters.AddWithValue("@TreatName", textBox1.Text);
            cnn.Parameters.AddWithValue("@TreatCost", textBox2.Text);
            cnn.Parameters.AddWithValue("@TreatDesc", richTextBox2.Text);
            cnn.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Saved Succesfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=schoolmdb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from TreatmentTbl", con);
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

        private void label6_Click_1(object sender, EventArgs e)
        {
            Main mnn = new Main();
            mnn.Show();
            this.Close();
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successfully", "OK");
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Presciption pres = new Presciption();
            pres.Show();
            this.Close();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Patient pat = new Patient();
            pat.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=schoolmdb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete TreatmentTbl where treatname=@treatname", con);
            SqlParameter sqlparameter = cnn.Parameters.AddWithValue("@TreatName", textBox1.Text);
            cnn.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Are you sure you want to delete the record? (the record will delete permanently)", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
    }
}
