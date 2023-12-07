using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Index_page
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string contdb = @"Data Source=SAFKAT-LAPTOP\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text == "" || txtUser.Text == "" || txtPass.Text == "" || txtCfrPass.Text == "")
            {
                MessageBox.Show("Please fill manatory fiels");
            }
            else if (txtPass.Text != txtCfrPass.Text)
            {
                MessageBox.Show("Password do not match");
            }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(contdb))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtfstNm.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", txtlsNm.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@UserName", txtUser.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", txtPass.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@ConfirmPassword", txtCfrPass.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is Successfull");

                    Clear();
                }
            }
        }
        void Clear()
        {
            txtfstNm.Text = txtlsNm.Text = txtEmail.Text = txtUser.Text = txtPass.Text = txtCfrPass.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
                txtCfrPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                txtCfrPass.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the form?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

