using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Index_page
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
    }
}
