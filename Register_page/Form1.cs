using System.Data;
using System.Data.SqlClient;
namespace Register_page
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        string contdb = @"Data Source=SAFKAT-LAPTOP\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True";
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCfrPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}