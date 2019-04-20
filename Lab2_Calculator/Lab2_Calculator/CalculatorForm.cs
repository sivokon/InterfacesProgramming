using System;
using System.Windows.Forms;

namespace Lab2_Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            userInput.Text += (sender as Button).Text;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (userInput.Text != string.Empty)
            {
                var lastSymbolIndex = userInput.Text.Length - 1;
                userInput.Text = userInput.Text.Remove(lastSymbolIndex);
            }
        }
    }
}
