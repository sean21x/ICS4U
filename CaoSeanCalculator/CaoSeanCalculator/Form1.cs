﻿using System;
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
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text == "12321")
                MessageBox.Show("That's the secret code!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        
        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void equalsign_Click(object sender, EventArgs e)
        {

        }
    }
}
