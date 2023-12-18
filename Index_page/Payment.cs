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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Payment is Complete");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Payment is Complete");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Payment is Complete");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Payment is Not Complete");
        }
    }
}
