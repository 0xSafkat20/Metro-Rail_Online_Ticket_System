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
    public partial class Seat : Form
    {
        public Seat()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Seat_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.White;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.Red;
            button15.ForeColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            button4.ForeColor = Color.White;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Seat seat = new Seat();
            seat.Show();
            this.Hide();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Hide();
        }
    }
}
