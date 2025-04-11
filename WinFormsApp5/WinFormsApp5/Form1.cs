using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using Microsoft.Data;
using Microsoft.Data.SqlClient;


namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=employeedb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            string username = txtusername.Text;
            string password = txtpassword.Text;
            SqlCommand cnn = new SqlCommand("select Username,Password from logintab where Username= '" + txtusername.Text + "'and Password='" + txtpassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            if (table.Rows.Count > 0)
            {
                Employee em = new Employee();
                em.Show();
            }

            else
            {
                MessageBox.Show("Invalid username/password. Please try again.");
            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
