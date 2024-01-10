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
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Index_page
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Global_Var.connstr);

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "Enter Your Email")
            {
                txtemail.Text = "";

                txtemail.ForeColor = Color.Black;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "Enter Your Email";

                txtemail.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (txtpass.Text == "Enter Your Password")
            {
                txtpass.Text = "";

                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Enter Your Password";

                txtpass.ForeColor = Color.Gray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the form?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Home form = new Home();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form = new Form3();
            form.Show();
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // int User_ID = 0;
            String email, password;
            email = txtemail.Text;
            password = txtpass.Text;

            if (txtemail.Text == "Admin" && txtpass.Text == "admin" || txtpass.Text == "iamadmin")
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }
            else
            {
                try
                {
                    string querry = "SELECT * FROM UserInfo WHERE email = '" + txtemail.Text + "' AND password = '" + txtpass.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        email = txtemail.Text;
                        password = txtpass.Text;

                        Destination form = new Destination();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email And Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtemail.Clear();
                        txtpass.Clear();

                        txtemail.Focus();
                    }
                }

                catch
                {
                    MessageBox.Show("Error");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", $"/c start https://www.facebook.com/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", $"/c start https://t.ly/flJCU");
        }
    }
}


