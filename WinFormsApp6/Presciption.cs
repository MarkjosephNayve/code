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
    public partial class Presciption : Form
    {
        public Presciption()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successfully", "OK");
            Form1 frm = new Form1();
            frm.Show();
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

        private void label6_Click(object sender, EventArgs e)
        {
            User us = new User();
            us.Show();
            this.Close();
        }

        private void label6_Click_1(object sender, EventArgs e)
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

        private void label3_Click_1(object sender, EventArgs e)
        {
            Patient pat = new Patient();
            pat.Show();
            this.Close();
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successfully", "OK");
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=schoolmdb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into PrescriptionTbl values (@patname,@treatname,@treatcost,@medicines,@medqty)", con);
            cnn.Parameters.AddWithValue("@PatName", textBox1.Text);
            cnn.Parameters.AddWithValue("@TreatName", comboBox1.Text);
            cnn.Parameters.AddWithValue("@TreatCost", textBox2.Text);
            cnn.Parameters.AddWithValue("@Medicines", richTextBox2.Text);
            cnn.Parameters.AddWithValue("@MedQty", textBox3.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Succesfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=schoolmdb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from PrescriptionTbl", con);
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
            SqlCommand cnn = new SqlCommand("delete PrescriptionTbl where patname=@patname", con);
            SqlParameter sqlparameter = cnn.Parameters.AddWithValue("@PatName", textBox1.Text);
            cnn.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Are you sure you want to delete the record? (the record will delete permanently)", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
    }
 }

