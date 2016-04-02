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
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            _a = decimal.Parse(inputTextBox.Text);
            inputTextBox.Text = "0";
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            _b = decimal.Parse(inputTextBox.Text);
            inputTextBox.Text = (_a + _b).ToString();
        }
    }
}