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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(TicketIfo.connstr);
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            
                SqlCommand cmd = new SqlCommand("INSERT INTO Location VALUES (@u_from, @u_to, @seat_type, @date)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@u_from", txtfrom.Text);
                cmd.Parameters.AddWithValue("@u_to", txtTo.Text);
                cmd.Parameters.AddWithValue("@seat_type", comboBox1.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString());
            cmd.ExecuteNonQuery();
                Seat seat = new Seat();
                seat.Show();
                this.Hide();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtfrom.Text == "From Station")
            {
                txtfrom.Text = "";

                txtfrom.ForeColor = Color.Black;
            }
        }

        private void txtfrom_Leave(object sender, EventArgs e)
        {
            if (txtfrom.Text == "")
            {
                txtfrom.Text = "From Station";

                txtfrom.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtTo.Text == "To Station")
            {
                txtTo.Text = "";

                txtTo.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtTo.Text == "")
            {
                txtTo.Text = "To Station";

                txtTo.ForeColor = Color.Gray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
