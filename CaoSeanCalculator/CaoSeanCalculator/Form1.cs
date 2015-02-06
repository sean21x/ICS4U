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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text += "A";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text == "CBABC")
                MessageBox.Show("That's the secret code!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text += "B";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += "C";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your text: " + textBox.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}
