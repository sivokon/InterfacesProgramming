using System;
using System.Windows.Forms;

namespace Lab2_Calculator
{
    public partial class CalculatorForm : Form
    {
        private readonly CalculatorService _calculatorService;

        private string _operation;
        private double _currentResult;
        private bool _lastBtnIsOperation;

        private const string Zero = "0";

        public CalculatorForm()
        {
            InitializeComponent();

            _calculatorService = new CalculatorService();

            Reset();
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Width = 272;
            txtDisplay.Width = 234;
            btnEquals.Width = 234;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Width = 530;
            txtDisplay.Width = 491;
            btnEquals.Width = 491;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;

            if (txtDisplay.Text == Zero || _lastBtnIsOperation)
            {
                txtDisplay.Text = string.Empty;
                _lastBtnIsOperation = false;
            }
            txtDisplay.Text += clicked.Text;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != string.Empty && !txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != Zero)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == string.Empty)
            {
                txtDisplay.Text = Zero;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BasicOperation_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;

            if (!string.IsNullOrEmpty(_operation))
            {
                _currentResult =
                    _calculatorService.GetOperationResult(_currentResult, double.Parse(txtDisplay.Text), _operation);
            }
            else
            {
                _currentResult = double.Parse(txtDisplay.Text);
            }

            _operation = clicked.Text;
            label.Text = $"{_currentResult} {_operation}";
            txtDisplay.Text = _currentResult.ToString();
            _lastBtnIsOperation = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            label.Text = Zero;

            txtDisplay.Text = _calculatorService
                .GetOperationResult(_currentResult, double.Parse(txtDisplay.Text), _operation)
                .ToString();

            _operation = string.Empty;
        }

        private void btnToggleSign_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != Zero && txtDisplay.Text != string.Empty)
            {
                txtDisplay.Text = (double.Parse(txtDisplay.Text) * -1).ToString();
            }
        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3.1415926535897932";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "2.7182818284590452";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            var operand = double.Parse(txtDisplay.Text);
            var sqrtResult = Math.Sqrt(operand);

            UpdateLabelAndInput(operand, sqrtResult, "Sqrt");
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            var operand = double.Parse(txtDisplay.Text);
            var log10Result = Math.Log10(operand);

            UpdateLabelAndInput(operand, log10Result, "Log");
        }

        private void UpdateLabelAndInput(double argument, double operationResult, string operationName)
        {
            if (!string.IsNullOrEmpty(_operation))
            {
                operationResult = _calculatorService.GetOperationResult(_currentResult, operationResult, _operation);
                label.Text += $" {operationName}({argument})";
                _operation = string.Empty;
            }
            else
            {
                label.Text = $"{operationName}({argument})";
            }
            txtDisplay.Text = operationResult.ToString();
        }

        private void Reset()
        {
            txtDisplay.Text = Zero;
            label.Text = Zero;
            _operation = string.Empty;
            _currentResult = 0.0;
            _lastBtnIsOperation = false;
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            var operand = double.Parse(txtDisplay.Text);
            var log10Result = Math.Log(operand);

            UpdateLabelAndInput(operand, log10Result, "Ln");
        }

        private void btnInv_Click(object sender, EventArgs e)
        {

        }

        private void btnXpow2_Click(object sender, EventArgs e)
        {
            var operand = double.Parse(txtDisplay.Text);
            var log10Result = Math.Pow(operand, 2);

            UpdateLabelAndInput(operand, log10Result, "^2");
        }

        private void btnXpow3_Click(object sender, EventArgs e)
        {
            var operand = double.Parse(txtDisplay.Text);
            var log10Result = Math.Pow(operand, 3);

            UpdateLabelAndInput(operand, log10Result, "^3");
        }

        private void btn10PowX_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = ((int)double.Parse(txtDisplay.Text)).ToString();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {

        }
    }
}
