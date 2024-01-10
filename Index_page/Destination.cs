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
    public partial class Destination : Form
    {
        SqlConnection con = new SqlConnection(TicketIfo.connstr);
        public Destination()
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
            cmd.Parameters.AddWithValue("@u_from", frmcom.Text);
            cmd.Parameters.AddWithValue("@u_to", tocombo.Text);
            cmd.Parameters.AddWithValue("@seat_type", comboBox1.Text);
            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString());
            cmd.ExecuteNonQuery();
            Seat seat = new Seat();
            seat.Show();
            this.Hide();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (frmcom.Text == "From Station")
            {
                frmcom.Text = "";

                frmcom.ForeColor = Color.Black;
            }
        }

        private void txtfrom_Leave(object sender, EventArgs e)
        {
            if (frmcom.Text == "")
            {
                frmcom.Text = "From Station";

                frmcom.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (tocombo.Text == "To Station")
            {
                tocombo.Text = "";

                tocombo.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (tocombo.Text == "")
            {
                tocombo.Text = "To Station";

                tocombo.ForeColor = Color.Gray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
