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
        private decimal _a;
        private decimal _b;

        public mainForm()
        {
            InitializeComponent();
        }

        private void digitButtonClick(string digit)
        {
            decimal temp;
            if (decimal.TryParse(inputTextBox.Text + digit, out temp))
            {
                inputTextBox.Text = temp.ToString();
            }
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            digitButtonClick("0");
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            digitButtonClick("1");
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            digitButtonClick("2");
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            digitButtonClick("3");
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            digitButtonClick("4");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            digitButtonClick("5");
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            digitButtonClick("6");
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            digitButtonClick("7");
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            digitButtonClick("8");
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            digitButtonClick("9");
        }
    }
}