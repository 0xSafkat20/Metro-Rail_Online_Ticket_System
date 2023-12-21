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
    public partial class InsertTicket : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SAFKAT-LAPTOP;Initial Catalog=project;Integrated Security=True");
        public InsertTicket()
        {
            InitializeComponent();
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Location VALUES (@RouitID,@Begining,@Reach) ", con);
            cmd.Parameters.AddWithValue("@RouitID", txtrouit.Text);
            cmd.Parameters.AddWithValue("@Begining", txtform.Text);
            cmd.Parameters.AddWithValue("@Reach", txtto.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Ticket Insert Succesfull");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin Ad = new Admin();
            Ad.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Location SET Begining=@Begining,Reach=@Reach WHERE RouitID=@RouitID", con);
            cmd.Parameters.AddWithValue("@RouitID", txtrouit.Text);
            cmd.Parameters.AddWithValue("@Begining", txtform.Text);
            cmd.Parameters.AddWithValue("@Reach", txtto.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Ticket Update Succesfull");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Location WHERE RouitID=@RouitID", con);
            cmd.Parameters.AddWithValue("@RouitID", txtrouit.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Ticket Delete Succesfull");
        }
    }
}
