using Lab2_Calculator.Services;
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

        private void btnEqual_Click(object sender, EventArgs e)
        {
            var inputs = userInput.Text.Split(' ');
            //MessageBox.Show(inputs.Length.ToString());
            var service = new Service();

            var result = service.Calculate(inputs);

            if (result != string.Empty)
            {
                userInput.Text = result;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            userInput.Text += $" {(sender as Button).Text} ";
        }

    }
}
