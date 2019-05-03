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
        private const string CannotDevideByZero = "Cannot devide by zero";

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

            if (txtDisplay.Text == Zero || txtDisplay.Text == CannotDevideByZero || _lastBtnIsOperation)
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

            if (_operation == "x^y")
            {
                label.Text = $"{_currentResult}^";
            }
            else
            {
                label.Text = $"{_currentResult} {_operation}";
            }

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

            UpdateLabelAndInputText(operand, sqrtResult, $"Sqrt({operand})");
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            var operand = double.Parse(txtDisplay.Text);
            var log10Result = Math.Log10(operand);

            UpdateLabelAndInputText(operand, log10Result, $"Log({operand})");
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            var operand = double.Parse(txtDisplay.Text);
            var lnResult = Math.Log(operand);

            UpdateLabelAndInputText(operand, lnResult, $"Ln({operand})");
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            var operand = double.Parse(txtDisplay.Text);

            if (operand == 0)
            {
                txtDisplay.Text = CannotDevideByZero;
            }
            else
            {
                var invResult = 1 / operand;
                UpdateLabelAndInputText(operand, invResult, $"1/{operand}");
            }
        }

        private void btnXpow2_Click(object sender, EventArgs e)
        {
            var operand = double.Parse(txtDisplay.Text);
            var pow2Result = Math.Pow(operand, 2);

            UpdateLabelAndInputText(operand, pow2Result, $"{operand}^2");
        }

        private void btnXpow3_Click(object sender, EventArgs e)
        {
            var operand = double.Parse(txtDisplay.Text);
            var pow3Result = Math.Pow(operand, 3);

            UpdateLabelAndInputText(operand, pow3Result, $"{operand}^3");
        }

        private void btn10PowX_Click(object sender, EventArgs e)
        {
            var operand = double.Parse(txtDisplay.Text);
            var pow10Result = Math.Pow(10, operand);

            UpdateLabelAndInputText(operand, pow10Result, $"10^{operand}");
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = ((int)double.Parse(txtDisplay.Text)).ToString();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {

        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            var operand = double.Parse(txtDisplay.Text);
            var sinResult = Math.Sin(operand);

            UpdateLabelAndInputText(operand, sinResult, $"sin({operand})");
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            var operand = double.Parse(txtDisplay.Text);
            var cosResult = Math.Cos(operand);

            UpdateLabelAndInputText(operand, cosResult, $"cos({operand})");
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            var operand = double.Parse(txtDisplay.Text);
            var tanResult = Math.Tan(operand);

            UpdateLabelAndInputText(operand, tanResult, $"tan({operand})");
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            var operand = double.Parse(txtDisplay.Text);
            var sinhResult = Math.Sinh(operand);

            UpdateLabelAndInputText(operand, sinhResult, $"sinh({operand})");
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            var operand = double.Parse(txtDisplay.Text);
            var coshResult = Math.Cosh(operand);

            UpdateLabelAndInputText(operand, coshResult, $"cosh({operand})");
        }

        private void Tanh_Click(object sender, EventArgs e)
        {
            var operand = double.Parse(txtDisplay.Text);
            var tanhResult = Math.Tanh(operand);

            UpdateLabelAndInputText(operand, tanhResult, $"tanh({operand})");
        }

        private void UpdateLabelAndInputText(double argument, double operationResult, string labelText)
        {
            if (!string.IsNullOrEmpty(_operation))
            {
                operationResult = _calculatorService.GetOperationResult(_currentResult, operationResult, _operation);
                label.Text += $" {labelText}";
                _operation = string.Empty;
            }
            else
            {
                label.Text = $"{labelText}";
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

        private void btnBin_Click(object sender, EventArgs e)
        {
            var operand = double.Parse(txtDisplay.Text);
            var binResult = Convert.ToString(5, 2);
        }
    }
}
