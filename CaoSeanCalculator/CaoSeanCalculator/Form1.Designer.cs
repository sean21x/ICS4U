namespace CaoSeanCalculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.equalsign = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.memAdd = new System.Windows.Forms.Button();
            this.memSubtract = new System.Windows.Forms.Button();
            this.memRecall = new System.Windows.Forms.Button();
            this.memClear = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.memIndicator = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(12, 109);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(40, 23);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(58, 109);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(40, 23);
            this.two.TabIndex = 1;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(104, 109);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(40, 23);
            this.three.TabIndex = 2;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // equalsign
            // 
            this.equalsign.Location = new System.Drawing.Point(104, 194);
            this.equalsign.Name = "equalsign";
            this.equalsign.Size = new System.Drawing.Size(132, 26);
            this.equalsign.TabIndex = 3;
            this.equalsign.Text = "=";
            this.equalsign.UseVisualStyleBackColor = true;
            this.equalsign.Click += new System.EventHandler(this.equalsign_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(224, 62);
            this.textBox.TabIndex = 4;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(12, 138);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(40, 23);
            this.four.TabIndex = 5;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(58, 138);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(40, 23);
            this.five.TabIndex = 6;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(104, 138);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(40, 23);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(12, 167);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(40, 23);
            this.seven.TabIndex = 8;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(58, 167);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(40, 23);
            this.eight.TabIndex = 9;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(104, 167);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(40, 23);
            this.nine.TabIndex = 10;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // memAdd
            // 
            this.memAdd.Location = new System.Drawing.Point(12, 80);
            this.memAdd.Name = "memAdd";
            this.memAdd.Size = new System.Drawing.Size(40, 23);
            this.memAdd.TabIndex = 11;
            this.memAdd.Text = "M+";
            this.memAdd.UseVisualStyleBackColor = true;
            this.memAdd.Click += new System.EventHandler(this.memAdd_Click);
            // 
            // memSubtract
            // 
            this.memSubtract.Location = new System.Drawing.Point(58, 80);
            this.memSubtract.Name = "memSubtract";
            this.memSubtract.Size = new System.Drawing.Size(40, 23);
            this.memSubtract.TabIndex = 12;
            this.memSubtract.Text = "M-";
            this.memSubtract.UseVisualStyleBackColor = true;
            this.memSubtract.Click += new System.EventHandler(this.memSubtract_Click);
            // 
            // memRecall
            // 
            this.memRecall.Location = new System.Drawing.Point(149, 80);
            this.memRecall.Name = "memRecall";
            this.memRecall.Size = new System.Drawing.Size(40, 23);
            this.memRecall.TabIndex = 13;
            this.memRecall.Text = "MR";
            this.memRecall.UseVisualStyleBackColor = true;
            this.memRecall.Click += new System.EventHandler(this.memRecall_Click);
            // 
            // memClear
            // 
            this.memClear.Location = new System.Drawing.Point(195, 80);
            this.memClear.Name = "memClear";
            this.memClear.Size = new System.Drawing.Size(40, 23);
            this.memClear.TabIndex = 14;
            this.memClear.Text = "MC";
            this.memClear.UseVisualStyleBackColor = true;
            this.memClear.Click += new System.EventHandler(this.memClear_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(150, 138);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(40, 23);
            this.plus.TabIndex = 15;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(196, 138);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(40, 23);
            this.minus.TabIndex = 16;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(150, 167);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(40, 23);
            this.multiply.TabIndex = 17;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(196, 167);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(40, 23);
            this.divide.TabIndex = 18;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(58, 196);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(40, 23);
            this.zero.TabIndex = 19;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(195, 109);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(40, 23);
            this.clear.TabIndex = 21;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // memIndicator
            // 
            this.memIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.memIndicator.Location = new System.Drawing.Point(20, 20);
            this.memIndicator.Name = "memIndicator";
            this.memIndicator.ReadOnly = true;
            this.memIndicator.Size = new System.Drawing.Size(23, 26);
            this.memIndicator.TabIndex = 22;
            this.memIndicator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.memIndicator.TextChanged += new System.EventHandler(this.memIndicator_TextChanged);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 229);
            this.Controls.Add(this.memIndicator);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.memClear);
            this.Controls.Add(this.memRecall);
            this.Controls.Add(this.memSubtract);
            this.Controls.Add(this.memAdd);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.equalsign);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button equalsign;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button memAdd;
        private System.Windows.Forms.Button memSubtract;
        private System.Windows.Forms.Button memRecall;
        private System.Windows.Forms.Button memClear;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox memIndicator;
    }
}

