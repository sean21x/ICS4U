/*
 * 
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
        }
        

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            /*if (textBox.Text == "12321")
                MessageBox.Show("That's the secret code!");
             */
        }

        private void equalsign_Click(object sender, EventArgs e)
        {
            if(plusFlag == true)
            {
                textBox.Text = Convert.ToString(temp1stnumber + Convert.ToInt32(textBox.Text));
                temp1stnumber = 0;
                plusFlag = false;
                isNotFirstDigit = false;
                equalSignPressed = true;
            }
            else if (minusFlag == true)
            {
                textBox.Text = Convert.ToString(temp1stnumber - Convert.ToInt32(textBox.Text));
                temp1stnumber = 0;
                minusFlag = false;
                isNotFirstDigit = false;
                equalSignPressed = true;
            }
            else if (multiplyFlag == true)
            {
                textBox.Text = Convert.ToString(temp1stnumber * Convert.ToInt32(textBox.Text));
                temp1stnumber = 0;
                multiplyFlag = false;
                isNotFirstDigit = false;
                equalSignPressed = true;
            }
            else if (divideFlag == true)
            {
                //int n = Convert.ToInt32(textBox.Text);

                //if (n == 0)
                //{
                //    textBox.Text = "infinite";
                //}
                //else
                //{

                textBox.Text = Convert.ToString(temp1stnumber / Convert.ToInt32(textBox.Text));
                //}

                temp1stnumber = 0;
                divideFlag = false;
                isNotFirstDigit = false;
                equalSignPressed = true;
            }
            else
            {
                temp1stnumber = 0;
                memFlag = false;
                plusFlag = false;
                minusFlag = false;
                multiplyFlag = false;
                divideFlag = false;
                isNotFirstDigit = false;
                equalSignPressed = true;
            }
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
                //plusFlag = false;
                //minusFlag = false;
                //multiplyFlag = false;
                //divideFlag = false;
            }
            else if ((plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true) && isNotFirstDigit == true)
                textBox.Text += Convert.ToString(value);
        }

        private void one_Click(object sender, EventArgs e)
        {
            digitClicked(1);
            //if ((memFlag == true || plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true || equalSignPressed == true) && isNotFirstDigit == false)
            //{
            //    textBox.Text = "1";
            //    memFlag = false;
            //    isNotFirstDigit = true;
                
            //    //plusFlag = false;
            //    //minusFlag = false;
            //    //multiplyFlag = false;
            //    //divideFlag = false;
            //}
            //else if (memFlag == false && plusFlag == false && minusFlag == false && multiplyFlag == false && divideFlag == false && equalSignPressed == true)
            //{
            //    if (Convert.ToInt32(textBox.Text) == 0)
            //        textBox.Text = "1";
            //    else
            //        textBox.Text += "1";              
            //}
            
            //else if ((plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true || equalSignPressed == false) && isNotFirstDigit == true)       
            //    textBox.Text += "1";
            //equalSignPressed = false;
        }

        //repeat steps from 1 for 2
        private void two_Click(object sender, EventArgs e)
        {
            digitClicked(2);
            //if (memFlag == false && plusFlag == false && minusFlag == false && multiplyFlag == false && divideFlag == false)
            //{
            //    if (Convert.ToInt32(textBox.Text) == 0)
            //        textBox.Text = "2";
            //    else
            //        textBox.Text += "2";
            //}
            //if ((memFlag == true || plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true) && isNotFirstDigit == false)
            //{
            //    textBox.Text = "2";
            //    memFlag = false;
            //    isNotFirstDigit = true;
            //    //plusFlag = false;
            //    //minusFlag = false;
            //    //multiplyFlag = false;
            //    //divideFlag = false;
            //}
            //else if ((plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true) && isNotFirstDigit == true)
            //    textBox.Text += "2";
        }

        //repeat steps from 1 for 3
        private void three_Click(object sender, EventArgs e)
        {
            digitClicked(3);
            //if (memFlag == false && plusFlag == false && minusFlag == false && multiplyFlag == false && divideFlag == false)
            //{
            //    if (Convert.ToInt32(textBox.Text) == 0)
            //        textBox.Text = "3";
            //    else
            //        textBox.Text += "3";
            //}
            //if ((memFlag == true || plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true) && isNotFirstDigit == false)
            //{
            //    textBox.Text = "3";
            //    memFlag = false;
            //    isNotFirstDigit = true;
            //    //plusFlag = false;
            //    //minusFlag = false;
            //    //multiplyFlag = false;
            //    //divideFlag = false;
            //}
            //else if ((plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true) && isNotFirstDigit == true)
            //    textBox.Text += "3";
        }

        //repeat steps from 1 for 4
        private void four_Click(object sender, EventArgs e)
        {
            digitClicked(4);
            //if (memFlag == false && plusFlag == false && minusFlag == false && multiplyFlag == false && divideFlag == false)
            //{
            //    if (Convert.ToInt32(textBox.Text) == 0)
            //        textBox.Text = "4";
            //    else
            //        textBox.Text += "4";
            //}
            //if (memFlag == true)
            //{
            //    textBox.Text = "4";
            //    memFlag = false;
            //    //plusFlag = false;
            //    //minusFlag = false;
            //    //multiplyFlag = false;
            //    //divideFlag = false;
            //}
            //if (plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true)
            //    textBox.Text += "4";
        }

        //repeat steps from 1 for 5
        private void five_Click(object sender, EventArgs e)
        {
            digitClicked(5);
            //if (memFlag == false && plusFlag == false && minusFlag == false && multiplyFlag == false && divideFlag == false)
            //{
            //    if (Convert.ToInt32(textBox.Text) == 0)
            //        textBox.Text = "5";
            //    else
            //        textBox.Text += "5";
            //}
            //if ((memFlag == true || plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true) && isNotFirstDigit == false)
            //{
            //    textBox.Text = "5";
            //    memFlag = false;
            //    isNotFirstDigit = true;
            //    //plusFlag = false;
            //    //minusFlag = false;
            //    //multiplyFlag = false;
            //    //divideFlag = false;
            //}
            //else if ((plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true) && isNotFirstDigit == true)
            //    textBox.Text += "5";
        }

        //repeat steps from 1 for 6
        private void six_Click(object sender, EventArgs e)
        {
            digitClicked(6);
            //if (memFlag == false && plusFlag == false && minusFlag == false && multiplyFlag == false && divideFlag == false)
            //{
            //    if (Convert.ToInt32(textBox.Text) == 0)
            //        textBox.Text = "6";
            //    else
            //        textBox.Text += "6";
            //}
            //else if ((memFlag == true || plusFlag == true || minusFlag == true || multiplyFlag == true
            //    || divideFlag == true || equalSignPressed == true) && isNotFirstDigit == false)
            //{
            //    textBox.Text = "6";
            //    memFlag = false;
            //    isNotFirstDigit = true;
            //    //plusFlag = false;
            //    //minusFlag = false;
            //    //multiplyFlag = false;
            //    //divideFlag = false;
            //}


            //else //((plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true) && isNotFirstDigit == true)
            //{
            //    textBox.Text += "6";
            //}
        }

        //repeat steps from 1 for 7
        private void seven_Click(object sender, EventArgs e)
        {
            digitClicked(7);
            //if (memFlag == false && plusFlag == false && minusFlag == false && multiplyFlag == false && divideFlag == false)
            //{
            //    if (Convert.ToInt32(textBox.Text) == 0)
            //        textBox.Text = "7";
            //    else
            //        textBox.Text += "7";
            //}

            //if ((memFlag == true || plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true) && isNotFirstDigit == false)
            //{
            //    textBox.Text = "7";
            //    memFlag = false;
            //    isNotFirstDigit = true;
            //    //plusFlag = false;
            //    //minusFlag = false;
            //    //multiplyFlag = false;
            //    //divideFlag = false;
            //}
            //else if ((plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true) && isNotFirstDigit == true)
            //    textBox.Text += "7";
        }

        //repeat steps from 1 for 8
        private void eight_Click(object sender, EventArgs e)
        {
            digitClicked(8);
            //if (memFlag == false && plusFlag == false && minusFlag == false && multiplyFlag == false && divideFlag == false)
            //{
            //    if (Convert.ToInt32(textBox.Text) == 0)
            //        textBox.Text = "8";
            //    else
            //        textBox.Text += "8";
            //}
            //if ((memFlag == true || plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true) && isNotFirstDigit == false)
            //{
            //    textBox.Text = "8";
            //    memFlag = false;
            //    isNotFirstDigit = true;
            //    //plusFlag = false;
            //    //minusFlag = false;
            //    //multiplyFlag = false;
            //    //divideFlag = false;
            //}
            //else if ((plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true) && isNotFirstDigit == true)
            //    textBox.Text += "8";
        }

        //repeat steps from 1 for 9
        private void nine_Click(object sender, EventArgs e)
        {
            digitClicked(9);
            //if (memFlag == false && plusFlag == false && minusFlag == false && multiplyFlag == false && divideFlag == false)
            //{
            //    if (Convert.ToInt32(textBox.Text) == 0)
            //        textBox.Text = "9";
            //    else
            //    textBox.Text += "9";
            //}
            //if ((memFlag == true || plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true) && isNotFirstDigit == false)
            //{
            //    textBox.Text = "9";
            //    memFlag = false;
            //    isNotFirstDigit = true;
            //    //plusFlag = false;
            //    //minusFlag = false;
            //    //multiplyFlag = false;
            //    //divideFlag = false;
            //}
            //else if ((plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true) && isNotFirstDigit == true)
            //    textBox.Text += "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (memFlag == false && plusFlag == false && minusFlag == false && multiplyFlag == false && divideFlag == false)//checks if memory or any other operator button has been clicked
            {
                if (Convert.ToInt32(textBox.Text) != 0)//checks if the number in the textbox is 0
                    textBox.Text += "0";//add 0 if it is not(we don't want 00 or 000 showing up
                else
                
                    textBox.Text = "0";
            }
            if (memFlag == true || plusFlag == true || minusFlag == true || multiplyFlag == true || divideFlag == true)
            {
                textBox.Text = "0";
                memFlag = false;
                //plusFlag = false;
                //minusFlag = false;
                //multiplyFlag = false;
                //divideFlag = false;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            plusFlag = true;
            temp1stnumber = Convert.ToInt32(textBox.Text);
        }

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
            //Console.Write(textBox.Text);
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
            plusFlag = false;
            isNotFirstDigit = false;
        }

        private void memIndicator_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
