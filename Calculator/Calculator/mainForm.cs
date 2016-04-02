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

        private void OnButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            digitButtonClick(button.Text);
        }
    }
}