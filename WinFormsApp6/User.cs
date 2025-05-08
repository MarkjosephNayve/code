using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Patient pat = new Patient();
            pat.Show();
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

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successfully");
            Form1 frm = new Form1();
            frm.Show();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
