﻿using System;
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
        private decimal _a;
        private decimal _b;
        private string _oper;
        private bool _isResultShown;
       
        public mainForm()
        {
            InitializeComponent();
        }

        private void digitButtonClick(string digit)
        {
            if (_isResultShown)
            {
                inputTextBox.Text = "0";
            }

            if (inputTextBox.Text.Length >= 14)
            {
                MessageBox.Show("Достигнута максимальная длина числа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;         
            }


            decimal temp;
            if (decimal.TryParse(inputTextBox.Text + digit, out temp))
            {
                inputTextBox.Text = temp.ToString();
            }
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            digitButtonClick(button.Text);
            _isResultShown = false;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            _a = decimal.Parse(inputTextBox.Text);
            inputTextBox.Text = "0";
            _oper = "+";
        }

        
        private void minusButton_Click(object sender, EventArgs e)
        {
            _a = decimal.Parse(inputTextBox.Text);
            inputTextBox.Text = "0";
            _oper = "-";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            _a = decimal.Parse(inputTextBox.Text);
            inputTextBox.Text = "0";
            _oper = "*";
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            _a = decimal.Parse(inputTextBox.Text);
            inputTextBox.Text = "0";
            _oper = "/";
        }

        private void invertButton_Click(object sender, EventArgs e)
        {
            decimal x = decimal.Parse(inputTextBox.Text);
            if (x == 0)
            {
                MessageBox.Show("На ноль делить нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal invert = 1 / x;
                inputTextBox.Text = invert.ToString();
                _isResultShown = true;
            }

        }

        private void squareRootButton_Click(object sender, EventArgs e)
        {
            double input = double.Parse(inputTextBox.Text);
            if (input >= 0)
            {
                double result = Math.Sqrt(input);
                inputTextBox.Text = result.ToString();
                _isResultShown = true;            
            }
            else
            {
                MessageBox.Show("Нельзя взять корень из отрицательного числа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            _b = decimal.Parse(inputTextBox.Text);

            decimal c = _b;
            if (_oper == "+")
            {
                c = _a + _b;
            }
            if (_oper == "-")
            {
                c = _a - _b;
            }
            if (_oper == "*")
            {
                c = _a * _b;
            }
            if (_oper == "/")
            {
                c = _a / _b;
            }
           
            inputTextBox.Text = c.ToString();
            _isResultShown = true;

        }

        private void clearEntryButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = "0";
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = "0";
            _a = 0;
            _b = 0;
            _oper = null;
            _isResultShown = false;
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text.Substring(0, inputTextBox.Text.Length - 1);
         
        }

        
    }
}