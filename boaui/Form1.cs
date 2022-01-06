using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boaui
{
    public partial class Form1 : Form
    {
        public int currentInt = 0;
        public string senhaInteira = "";
        public Form1()
        {
            InitializeComponent();
        }
        public void changeLabel()
        {
            int val1 = one.Checked ? 1 : 0;
            int val2 = two.Checked ? 2 : 0;
            int val4 = four.Checked ? 4 : 0;
            int val8 = eight.Checked ? 8 : 0;
            int val16 = sixteen.Checked ? 16 : 0;
            int val32 = thirtytwo.Checked ? 32 : 0;
            int val64 = sixtyfour.Checked ? 64 : 0;
            int val128 = onetwentyeight.Checked ? 128 : 0;
            currentInt = val1 + val2 + val4 + val8 + val16 + val32 + val64 + val128;
            if (currentInt > 32) 
            {
                letra.Text = ((char)currentInt).ToString();
            }
            else 
            {
                letra.Text = ("");
            }
        }
        private void one_CheckedChanged(object sender, EventArgs e)
        {
            changeLabel();
        }
        private void two_CheckedChanged(object sender, EventArgs e)
        {
            changeLabel();
        }

        private void four_CheckedChanged(object sender, EventArgs e)
        {
            changeLabel();
        }

        private void eight_CheckedChanged(object sender, EventArgs e)
        {
            changeLabel();
        }

        private void sixteen_CheckedChanged(object sender, EventArgs e)
        {
            changeLabel();
        }

        private void thirtytwo_CheckedChanged(object sender, EventArgs e)
        {
            changeLabel();
        }

        private void sixtyfour_CheckedChanged(object sender, EventArgs e)
        {
            changeLabel();
        }

        private void onetwentyeight_CheckedChanged(object sender, EventArgs e)
        {
            changeLabel();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            senhaInteira += ((char)currentInt).ToString();
            senha.Text = senhaInteira;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Invalid Username or Password.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ajuda = new Form2();
            ajuda.Show();
        }
    }
}
