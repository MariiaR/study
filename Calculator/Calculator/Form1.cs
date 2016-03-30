using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class mainForm : Form
    {
        float a, b;
        int count;
        bool sign = true;

        public mainForm()
        {
            InitializeComponent();
        }

        private void calculate()
        {switch(count)
            {
                case 1:
                    b = a + float.Parse(inputTextBox.Text);
                    inputTextBox.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(inputTextBox.Text);
                    inputTextBox.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(inputTextBox.Text);
                    inputTextBox.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(inputTextBox.Text);
                    inputTextBox.Text = b.ToString();
                    break;
                default:
                    break;
                case 5:
                    float divider;
                    divider = float.Parse(inputTextBox.Text);
                    if (divider == 00)
                        MessageBox.Show("error");
                    else
                    {
                        b = a / divider;
                        inputTextBox.Text = b.ToString();
                    }
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text + 0;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text + 1;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text + 2;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {

            inputTextBox.Text = inputTextBox.Text + 3;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text + 4;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text + 5;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text + 6;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text + 7;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text + 8;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text + 9;
        }

        private void commaButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text + ".";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            a = float.Parse(inputTextBox.Text);
            inputTextBox.Clear();
            count = 1;
            sign = true;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            a = float.Parse(inputTextBox.Text);
            inputTextBox.Clear();
            count = 2;
            sign = true;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            a = float.Parse(inputTextBox.Text);
            inputTextBox.Clear();
            count = 3;
            sign = true;
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            a = float.Parse(inputTextBox.Text);
            inputTextBox.Clear();
            count = 4;
            sign = true;
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = "";
                    }

        private void plusMinusButton_Click(object sender, EventArgs e)
        {
            if (sign==true)
            {
                inputTextBox.Text = "-" + inputTextBox.Text;
                sign = false;
            }
            else if (sign==false)
            {
                inputTextBox.Text = inputTextBox.Text.Replace("-", "");
                sign = true;
            }
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            int lenght = inputTextBox.Text.Length - 1;
            string text = inputTextBox.Text;
            inputTextBox.Clear();
            for (int i = 0; i < lenght; i++)
            {
                inputTextBox.Text = inputTextBox.Text + text[i];
            }

        }
    }
}