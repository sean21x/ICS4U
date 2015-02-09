/* This application is a calculator that calculates simple math
 * There is a memory feature available as a well as a Memory indicator(top left of display)
 * There are no decimals...
 * Using the numericUpDown, you can change the color of the text in the display(in terms of red)
 * I learned that it's really difficult to make a program without bugs
 * There are many cases of calculation that I have appeared to miss
 */

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
        private bool memFlag = false;
        private bool plusFlag = false;
        private bool minusFlag = false;
        private bool multiplyFlag = false;
        private bool divideFlag = false;
        private bool isNotFirstDigit = false;
     
        public Calculator()
        {
            InitializeComponent();
            textBox.Text = "0"; //start the calculator with a 0
        }

        private void equalsign_Click(object sender, EventArgs e)
        {
            if(plusFlag == true)
                textBox.Text = Convert.ToString(temp1stnumber + Convert.ToInt32(textBox.Text));          
            else if (minusFlag == true)
                textBox.Text = Convert.ToString(temp1stnumber - Convert.ToInt32(textBox.Text));
            else if (multiplyFlag == true)
                textBox.Text = Convert.ToString(temp1stnumber * Convert.ToInt32(textBox.Text));
            else if (divideFlag == true)
            {
                if (textBox.Text != "0")
                    textBox.Text = Convert.ToString(temp1stnumber / Convert.ToInt32(textBox.Text));
                else
                {
                    errorIndicator.Text = "E";
                    textBox.Text = "0";
                }      
            }
                temp1stnumber = 0;
                memFlag = false;
                plusFlag = false;
                minusFlag = false;
                multiplyFlag = false;
                divideFlag = false;
                isNotFirstDigit = false;
            
        }

        private void digitClicked(int value)
        {
            if (memFlag == false && plusFlag == false && minusFlag == false && multiplyFlag == false && divideFlag == false)
            {
                if (Convert.ToInt32(textBox.Text) == 0)
                    textBox.Text = Convert.ToString(value);
                else
                    textBox.Text += value;
            }
            if ((memFlag == true || plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true) && isNotFirstDigit == false)
            {
                textBox.Text = Convert.ToString(value);
                memFlag = false;
                isNotFirstDigit = true;
            }
            else if ((plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true) && isNotFirstDigit == true)
                textBox.Text += Convert.ToString(value);
        }

        private void one_Click(object sender, EventArgs e)
        {
            digitClicked(1);
        }

        private void two_Click(object sender, EventArgs e)
        {
            digitClicked(2);
        }

        private void three_Click(object sender, EventArgs e)
        {
            digitClicked(3);
        }

        private void four_Click(object sender, EventArgs e)
        {
            digitClicked(4);
        }

        //if 5 is clicked
        private void five_Click(object sender, EventArgs e)
        {
            digitClicked(5);
        }

        //if 6 is clicked
        private void six_Click(object sender, EventArgs e)
        {
            digitClicked(6);
        }

        //if 7 is clicked
        private void seven_Click(object sender, EventArgs e)
        {
            digitClicked(7);
        }

        //if 8 is clicked
        private void eight_Click(object sender, EventArgs e)
        {
            digitClicked(8);
        }

        //if 9 is clicked
        private void nine_Click(object sender, EventArgs e)
        {
            digitClicked(9);
        }

        //if 0 is clicked
        private void zero_Click(object sender, EventArgs e)
        {
            if (memFlag == false && plusFlag == false && minusFlag == false && multiplyFlag == false && divideFlag == false)//checks if memory or any other operator button has been clicked
            {
                if (Convert.ToInt32(textBox.Text) != 0)//checks if the number in the textbox is 0
                    textBox.Text += "0";//add 0 if it is not(we don't want 00 or 000 showing up
                else
                    textBox.Text = "0";//makes the text 0(keeps it at 0)
            }
            if (memFlag == true || plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true)
            {
                textBox.Text = "0";
                memFlag = false;
            }
        }

        //if the plus button is clicked
        private void plus_Click(object sender, EventArgs e)
        {
            plusFlag = true;
            temp1stnumber = Convert.ToInt32(textBox.Text);
        }

        //if the minus button is clicked
        private void minus_Click(object sender, EventArgs e)
        {
            minusFlag = true;
            temp1stnumber = Convert.ToInt32(textBox.Text);
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            multiplyFlag = true;
            temp1stnumber = Convert.ToInt32(textBox.Text);
        }

        private void divide_Click(object sender, EventArgs e)
        {
            divideFlag = true;
            temp1stnumber = Convert.ToInt32(textBox.Text);
        }

        private void memAdd_Click(object sender, EventArgs e)
        {
            memFlag = true;
            memory += Convert.ToInt32(textBox.Text);
            if (memory != 0)
                memIndicator.Text = "M";
            else
                memIndicator.Text = "";
        }

        private void memSubtract_Click(object sender, EventArgs e)
        {
            memFlag = true;
            memory -= Convert.ToInt32(textBox.Text);
            if (memory != 0)
                memIndicator.Text = "M";
            else
                memIndicator.Text = "";
        }

        private void memRecall_Click(object sender, EventArgs e)
        {
            memFlag = true;
            textBox.Text = Convert.ToString(memory);
        }

        private void memClear_Click(object sender, EventArgs e)
        {
            memory = 0;
            memFlag = true;
            if (memory != 0)
                memIndicator.Text = "M";
            else
                memIndicator.Text = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            temp1stnumber = 0;
            memFlag = false;
            plusFlag = false;
            minusFlag = false;
            multiplyFlag = false;
            divideFlag = false;
            isNotFirstDigit = false;
            errorIndicator.Text = "";
        }

    }
}
