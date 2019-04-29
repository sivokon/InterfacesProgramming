using Lab2_Calculator.models;
using System;
using System.Windows.Forms;

namespace Lab2_Calculator
{
    public partial class CalculatorForm : Form
    {
        private readonly CalculatorService _calculatorService;
        private string _operation;
        private double _result;
        private const string Zero = "0";

        public CalculatorForm()
        {
            InitializeComponent();

            _calculatorService = new CalculatorService();
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Width = 272;
            userInput.Width = 234;
            btnEquals.Width = 234;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Width = 530;
            userInput.Width = 491;
            btnEquals.Width = 491;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;

            if (userInput.Text == Zero)
            {
                userInput.Text = string.Empty;
            }
            userInput.Text += clicked.Text;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!userInput.Text.Contains("."))
            {
                userInput.Text += ".";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (userInput.Text != Zero)
            {
                userInput.Text = userInput.Text.Remove(userInput.Text.Length - 1, 1);
            }
            if (userInput.Text == string.Empty)
            {
                userInput.Text = Zero;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            userInput.Text = Zero;
            label.Text = Zero;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            userInput.Text = Zero;
            label.Text = Zero;
        }

        private void BasicOperation_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;

            if (!string.IsNullOrEmpty(_operation))
            {
                _result = 
                    _calculatorService.GetOperationResult(_result, double.Parse(userInput.Text), _operation);
            }
            else
            {
                _result = double.Parse(userInput.Text);
            }

            _operation = clicked.Text;
            label.Text = $"{_result} {_operation}";
            userInput.Text = Zero;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            label.Text = Zero;

            userInput.Text = _calculatorService
                .GetOperationResult(_result, double.Parse(userInput.Text), _operation)
                .ToString();

            _operation = string.Empty;
        }

        private void btnToggleSign_Click(object sender, EventArgs e)
        {
            if (userInput.Text != Zero)
            {
                userInput.Text = (double.Parse(userInput.Text) * -1).ToString();
            }
        }

    }
}
