﻿/* This application is a calculator that calculates simple math
 * There is a memory feature available as a well as a Memory indicator(top left of display)
 * There are no decimals...
 * Using the numericUpDown, you can change background color for the display(16 to choose from)
 * I learned that it's really difficult to make a program without bugs
 * There are many cases of calculation that I have appeared to miss
 * You cannot do 2 calculations in a row! For example, 2 + 4 + 3 will NOT work
 * Division does not work unless numbers are whole
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
        private bool equalSignPressed = false;
     
        public Calculator()
        {
            InitializeComponent();
            textBox.Text = "0"; //start the calculator with a 0
            textBox.BackColor = Color.White;
        }
        
        //if the equalsign is clicked
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
                equalSignPressed = true;
            
        }

        //a method for all digits except 0
        private void digitClicked(int value)
        {
            if (memFlag == false && plusFlag == false && minusFlag == false && multiplyFlag == false && divideFlag == false)//checks if any operation has been clicked, and if not, continues
            {
                if (Convert.ToInt32(textBox.Text) == 0 || equalSignPressed == true)//checks if the text is 0 or if equal sign has been pressed before
                    textBox.Text = Convert.ToString(value);//sets the number to the number pressed
                else
                    textBox.Text += value;//add 
            }
            if ((memFlag == true || plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true) && isNotFirstDigit == false)
            {
                textBox.Text = Convert.ToString(value);
                memFlag = false;
                isNotFirstDigit = true;
            }
            else if ((memFlag == true || plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true) && isNotFirstDigit == true)
            {
                textBox.Text += Convert.ToString(value);
                memFlag = false;
            }

            
            equalSignPressed = false;
        }

        //if 1 is clicked
        private void one_Click(object sender, EventArgs e)
        {
            digitClicked(1);
        }

        //if 2 is clicked
        private void two_Click(object sender, EventArgs e)
        {
            digitClicked(2);
        }

        //if 3 is clicked
        private void three_Click(object sender, EventArgs e)
        {
            digitClicked(3);
        }
        //if 4 is clicked
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
            digitClicked(0);
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

        //if memory clear is clicked(resets memory)
        private void memClear_Click(object sender, EventArgs e)
        {
            memory = 0;
            memFlag = true;
            if (memory != 0)
                memIndicator.Text = "M";
            else
                memIndicator.Text = "";
        }

        //if Clear is clicked(resets everything)
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

        //if the numericUpDown color changer value is changed
        private void ColorChanger_ValueChanged(object sender, EventArgs e)
        {
            if (ColorChanger.Value == 0)
                textBox.BackColor = Color.White;
            if (ColorChanger.Value == 1)
                textBox.BackColor = Color.AliceBlue;
            if (ColorChanger.Value == 2)
                textBox.BackColor = Color.Aqua;
            if (ColorChanger.Value == 3)
                textBox.BackColor = Color.Azure;
            if (ColorChanger.Value == 4)
                textBox.BackColor = Color.Beige;
            if (ColorChanger.Value == 5)
                textBox.BackColor = Color.CadetBlue;
            if (ColorChanger.Value == 6)
                textBox.BackColor = Color.Cyan;
            if (ColorChanger.Value == 7)
                textBox.BackColor = Color.Crimson;
            if (ColorChanger.Value == 8)
                textBox.BackColor = Color.Coral;
            if (ColorChanger.Value == 9)
                textBox.BackColor = Color.DarkGoldenrod;
            if (ColorChanger.Value == 10)
                textBox.BackColor = Color.DeepSkyBlue;
            if (ColorChanger.Value == 11)
                textBox.BackColor = Color.Green;
            if (ColorChanger.Value == 12)
                textBox.BackColor = Color.LemonChiffon;
            if (ColorChanger.Value == 13)
                textBox.BackColor = Color.Maroon;
            if (ColorChanger.Value == 14)
                textBox.BackColor = Color.LimeGreen;
            if (ColorChanger.Value == 15)
                textBox.BackColor = Color.Pink;
            if (ColorChanger.Value == 16)
                textBox.BackColor = Color.Violet;
        }

    }
}
