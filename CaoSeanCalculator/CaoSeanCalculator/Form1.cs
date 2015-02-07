using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaoSeanCalculator
{
    public partial class Calculator : Form
    {
        //Declaring private variables here
        private int memory = 0;
        private int temp1stnumber = 0;

        public Calculator()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*if (textBox.Text == "12321")
                MessageBox.Show("That's the secret code!");
             */
        }

        private void equalsign_Click(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {

        }

        private void minus_Click(object sender, EventArgs e)
        {

        }

        private void multiply_Click(object sender, EventArgs e)
        {

        }

        private void divide_Click(object sender, EventArgs e)
        {

        }

        private void memAdd_Click(object sender, EventArgs e)
        {
            memory += Convert.ToInt32(textBox.Text);
        }

        private void memSubtract_Click(object sender, EventArgs e)
        {
            memory -= Convert.ToInt32(textBox.Text);
        }

        private void memRecall_Click(object sender, EventArgs e)
        {
            textBox.Text = Convert.ToString(memory);
        }

        private void memClear_Click(object sender, EventArgs e)
        {
            memory = 0;
            textBox.Text = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }
    }
}
