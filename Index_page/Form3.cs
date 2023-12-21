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
        string contdb = @"Data Source=SAFKAT-LAPTOP;Initial Catalog=project;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }
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
                    Clear();
                    MessageBox.Show("Registration is Successfull");
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

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCfrPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

