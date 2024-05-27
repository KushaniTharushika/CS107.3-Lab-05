using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_05_A
{
    public partial class Form1 : Form
    {
        int num1, num2, Result;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void buttonMal_Click(object sender, EventArgs e)
        {
            Operation = "*";
            num1 = int.Parse(txtResult.Text);
            txtResult.Clear();
        }

        private void buttonDivi_Click(object sender, EventArgs e)
        {
            Operation = "/";
            num1 = int.Parse(txtResult.Text);
            txtResult.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtResult.Text);

            if (Operation == ("+"))
            {
                Result = num1 + num2;

            }
            else if (Operation == ("-"))
            {
                Result = num1 - num2;

            }
            else if (Operation == ("*"))
            {
                Result = num1 * num2;
            }
            else if (Operation == ("/"))
            {

                if (num2 == 0)
                {
                    MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Result = num1 / num2;
                }
            }
            txtResult.Show();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            Result = 0;
            num1 = 0;
            num2 = 0;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            Operation = "-";
            num1 = int.Parse(txtResult.Text);
            txtResult.Clear();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Operation = "+";
            num1 = int.Parse(txtResult.Text);
            txtResult.Clear();
        }



    }
}

