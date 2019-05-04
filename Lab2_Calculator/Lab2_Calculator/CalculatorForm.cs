using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2_Calculator
{
    enum ViewType
    {
        Standart,
        Scientific,
        Programmer
    }

    public partial class CalculatorForm : Form
    {
        private readonly CalculatorService _calculatorService;

        private string _operation;
        private double _currentResult;
        private bool _lastBtnIsOperation;
        private ViewType _currentViewType;

        private const string Zero = "0";
        private const string CannotDevideByZero = "Cannot devide by zero";

        public CalculatorForm()
        {
            InitializeComponent();

            _calculatorService = new CalculatorService();

            Reset();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            _currentViewType = ViewType.Standart;

            Width = 272;
            txtDisplay.Width = 234;
            btnEquals.Width = 234;
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentViewType = ViewType.Standart;

            Width = 272;
            txtDisplay.Width = 234;
            btnEquals.Width = 234;

            btnPoint.Enabled = true;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentViewType = ViewType.Scientific;

            Width = 530;
            txtDisplay.Width = 491;
            btnEquals.Width = 234;

            panelProgrammer.Visible = false;
            panelScientific.Visible = true;
            panelScientific.Location = new Point(267, 86);

            btnPoint.Enabled = true;
        }

        private void programmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentViewType = ViewType.Programmer;

            Width = 580;
            txtDisplay.Width = 541;
            btnEquals.Width = 234;

            panelProgrammer.Visible = true;
            panelScientific.Visible = false;
            panelProgrammer.Location = new Point(267, 86);

            rbDec.Checked = true;
            btnPoint.Enabled = false;
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

            var inputValue = 0.0;
            
            if (_currentViewType == ViewType.Programmer)
            {
                if (rbHex.Checked)
                {
                    inputValue = Convert.ToInt32(txtDisplay.Text, 16);
                }
                else if (rbDec.Checked)
                {
                    inputValue = double.Parse(txtDisplay.Text);
                }
                else if (rbOct.Checked)
                {
                    inputValue = Convert.ToInt32(txtDisplay.Text, 8);
                }
                else
                {
                    inputValue = Convert.ToInt32(txtDisplay.Text, 2);
                }
            }
            else
            {
                inputValue = double.Parse(txtDisplay.Text);
            }

            if (!string.IsNullOrEmpty(_operation))
            {
                _currentResult =
                    _calculatorService.GetOperationResult(_currentResult, inputValue, _operation);
            }
            else
            {
                _currentResult = inputValue;
            }

            _operation = clicked.Text;

            var txtResult = _currentResult.ToString();

            if (_currentViewType == ViewType.Programmer)
            {
                if (rbHex.Checked)
                {
                    txtResult = ((int)_currentResult).ToString("x").ToUpper();
                }
                else if (rbOct.Checked)
                {
                    txtResult = Convert.ToString((int)_currentResult, 8);
                }
                else if (rbBin.Checked)
                {
                    txtResult = Convert.ToString((int)_currentResult, 2);
                }
            }

            if (_operation == "x^y")
            {
                label.Text = $"{txtResult}^";
            }
            else
            {
                label.Text = $"{txtResult} {_operation}";
            }

            txtDisplay.Text = txtResult;
            _lastBtnIsOperation = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            var inputValue = 0.0;

            if (_currentViewType == ViewType.Programmer)
            {
                if (rbHex.Checked)
                {
                    inputValue = Convert.ToInt32(txtDisplay.Text, 16);
                }
                else if (rbDec.Checked)
                {
                    inputValue = double.Parse(txtDisplay.Text);
                }
                else if (rbOct.Checked)
                {
                    inputValue = Convert.ToInt32(txtDisplay.Text, 8);
                }
                else
                {
                    inputValue = Convert.ToInt32(txtDisplay.Text, 2);
                }
            }
            else
            {
                inputValue = double.Parse(txtDisplay.Text);
            }

            var result = _calculatorService.GetOperationResult(_currentResult, inputValue, _operation);

            if (_currentViewType == ViewType.Programmer)
            {
                if (rbHex.Checked)
                {
                    txtDisplay.Text = ((int)result).ToString("x").ToUpper();
                }
                else if (rbDec.Checked)
                {
                    txtDisplay.Text = result.ToString();
                }
                else if (rbOct.Checked)
                {
                    txtDisplay.Text = Convert.ToString((int)result, 8);
                }
                else if (rbBin.Checked)
                {
                    txtDisplay.Text = Convert.ToString((int)result, 2);
                }
            }
            else
            {
                txtDisplay.Text = result.ToString();
            }

            label.Text = Zero;
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

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            if (_currentViewType == ViewType.Programmer && txtDisplay.Text != string.Empty)
            {
                if (rbHex.Checked)
                {
                    lblHex.Text = txtDisplay.Text.ToUpper();
                    lblDec.Text = Convert.ToInt32(txtDisplay.Text, 16).ToString();
                    lblOct.Text = Convert.ToString(Convert.ToInt32(txtDisplay.Text, 16), 8);
                    lblBin.Text = Convert.ToString(Convert.ToInt32(txtDisplay.Text, 16), 2);
                }
                else if (rbDec.Checked)
                {
                    var input = int.Parse(txtDisplay.Text);
                    
                    lblHex.Text = input.ToString("x").ToUpper();
                    lblDec.Text = input.ToString();
                    lblOct.Text = Convert.ToString(input, 8);
                    lblBin.Text = Convert.ToString(input, 2);
                }
                else if (rbOct.Checked)
                {
                    lblHex.Text = Convert.ToInt32(txtDisplay.Text, 8).ToString("x").ToUpper();
                    lblDec.Text = Convert.ToInt32(txtDisplay.Text, 8).ToString();
                    lblOct.Text = txtDisplay.Text;
                    lblBin.Text = Convert.ToString(Convert.ToInt32(txtDisplay.Text, 8), 2);
                }
                else
                {
                    lblHex.Text = Convert.ToInt32(txtDisplay.Text, 2).ToString("x").ToUpper();
                    lblDec.Text = Convert.ToInt32(txtDisplay.Text, 2).ToString();
                    lblOct.Text = Convert.ToString(Convert.ToInt32(txtDisplay.Text, 2), 8);
                    lblBin.Text = txtDisplay.Text;
                }
            }
        }

        private void rbHex_CheckedChanged(object sender, EventArgs e)
        {
            SwitchHexButtons(true);
            SwitchOctButtons(true);
            SwitchBinButtons(true);

            txtDisplay.Text = lblHex.Text;
        }

        private void rbDec_CheckedChanged(object sender, EventArgs e)
        {
            SwitchHexButtons(false);
            SwitchOctButtons(true);
            SwitchBinButtons(true);

            txtDisplay.Text = lblDec.Text;
        }

        private void rbOct_CheckedChanged(object sender, EventArgs e)
        {
            SwitchHexButtons(false);
            SwitchOctButtons(false);
            SwitchBinButtons(true);

            txtDisplay.Text = lblOct.Text;
        }

        private void rbBin_CheckedChanged(object sender, EventArgs e)
        {
            SwitchHexButtons(false);
            SwitchOctButtons(false);
            SwitchBinButtons(false);

            txtDisplay.Text = lblBin.Text;
        }

        private void SwitchHexButtons(bool value)
        {
            btnA.Enabled = value;
            btnB.Enabled = value;
            btnC.Enabled = value;
            btnD.Enabled = value;
            btnE.Enabled = value;
            btnF.Enabled = value;
        }

        private void SwitchOctButtons(bool value)
        {
            btn8.Enabled = value;
            btn9.Enabled = value;
        }

        private void SwitchBinButtons(bool value)
        {
            btn2.Enabled = value;
            btn3.Enabled = value;
            btn4.Enabled = value;
            btn5.Enabled = value;
            btn6.Enabled = value;
            btn7.Enabled = value;
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

    }
}
