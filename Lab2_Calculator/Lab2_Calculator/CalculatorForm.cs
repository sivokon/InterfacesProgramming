using Lab2_Calculator.Services;
using System;
using System.Windows.Forms;

namespace Lab2_Calculator
{
    public partial class CalculatorForm : Form
    {
        private const string Zero = "0";

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            userInput.Text = Zero;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            var btnText = (sender as Button).Text;
            
            if (userInput.Text == Zero)
            {
                if (btnText == ".")
                {
                    userInput.Text = Zero + ".";
                }
                else
                {
                    userInput.Text = btnText;
                }
            }
            else if (!(userInput.Text.EndsWith(".") && btnText == "."))
            {
                userInput.Text += btnText;
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (userInput.Text.EndsWith(" "))
            {
                userInput.Text.Remove(userInput.Text.LastIndexOf(" "));
            }
            if (userInput.Text.Contains(" "))
            {
                userInput.Text = userInput.Text.Remove(userInput.Text.LastIndexOf(" "));
            }
            else
            {
                userInput.Text = string.Empty;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            userInput.Text += $" {(sender as Button).Text} ";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            var inputs = userInput.Text.Split(' ');

            var service = new Service();

            var result = service.Calculate(inputs);

            if (result != string.Empty)
            {
                userInput.Text = result;
            }
        }

    }
}
