using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.Data.SqlClient;

namespace WinFormsApp5
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=employeedb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into emptab values(@empid,@employeename,@dateofbirth,@emailaddress,@completeaddress,@salary)", con);
            SqlParameter sqlparameter = cnn.Parameters.AddWithValue("@EmpID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@EmployeeName", textBox2.Text);
            cnn.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("@EmailAddress", textBox3.Text);
            cnn.Parameters.AddWithValue("@CompleteAddress", textBox4.Text);
            cnn.Parameters.AddWithValue("@Salary", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Saved Successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=employeedb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from emptab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=employeedb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("update emptab set employeename=@employeename,dateofbirth=@dateofbirth,emailaddress=@emailaddress,completeaddress=@completeaddress,salary=@salary where empid=@empid", con);
            SqlParameter sqlparameter = cnn.Parameters.AddWithValue("@EmpID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@EmployeeName", textBox2.Text);
            cnn.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("@EmailAddress", textBox3.Text);
            cnn.Parameters.AddWithValue("@CompleteAddress", textBox4.Text);
            cnn.Parameters.AddWithValue("@Salary", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Updated Successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=employeedb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete emptab where empid=@empid", con);
            SqlParameter sqlparameter = cnn.Parameters.AddWithValue("@EmpID", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Deleted Successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=employeedb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from emptab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void showdata()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=employeedb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from emptab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=employeedb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from emptab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            lblcount.Text = dataTable.Rows.Count.ToString();
            showdata();
        }
    }
}
