using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Index_page
{
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(Global_Var.connstr);

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
          //  label2.Text = Global_Var.username;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtNewPas.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPas.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCurpas.Text == "" || txtNewPas.Text == "" || txtConPass.Text == "")
            {
                MessageBox.Show("Please fill manatory fiels");
            }
            else if (txtNewPas.Text != txtConPass.Text)
            {
                MessageBox.Show("Password do not match");
            }
            else
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
