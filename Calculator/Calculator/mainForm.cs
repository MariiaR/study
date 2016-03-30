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
        private float _a;
        private float _b;

        public mainForm()
        {
            InitializeComponent();
        }

        private void Ololo(string digit)
        {
            float temp;
            if (float.TryParse(inputTextBox.Text + digit, out temp))
            {
                inputTextBox.Text = temp.ToString();
            }
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            Ololo("0");
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            Ololo("1");
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            Ololo("2");
        }
    }
}