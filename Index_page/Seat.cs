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
        string text;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                text = " SkyRail Metro (Arrive 8 AM  Reach  3 PM)";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                text = " SkyRail Metro (Arrive 12 PM Reach 5 PM)";
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                text = " Urban Express Rail (Arrive 10 AM Reach 5 PM)";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                text = "Urban Express Rail (Arrive 2 PM Reach 9 PM)";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                text = "CityRail Express (Arrive 10 PM Reach 7 AM)";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                text = "CityRail Express (Arrive 12 PM Reach 9 AM)";
            }
        }

    }
}
