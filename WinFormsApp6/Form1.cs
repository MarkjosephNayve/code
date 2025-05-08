using System;
using System.Threading.Tasks;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0DRBOS\SQLEXPRESS;Initial Catalog=schoolmdb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            String userid = txtuserid.Text;
            String password = txtpassword.Text;
            SqlCommand cnn = new SqlCommand("select UserId,Password from logintabs where UserId='" + txtuserid.Text + "'and Password='" + txtpassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Patient mnn = new Patient();
                mnn.Show();
            }
            else
            {
                MessageBox.Show("Invalid User ID Or Password");
            }
            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

    }
}
