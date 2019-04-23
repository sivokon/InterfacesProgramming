using Lab2_Calculator.Services;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
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
            var result = ExpressionCalculator.Calc(userInput.Text.Replace('x', '*')).ToString();
            //var service = new Service();

            //var result = service.Calculate(userInput.Text.Replace('x', '*'));

            if (result != string.Empty)
            {
                userInput.Text = result;
            }
        }

    }

    public static class ExpressionCalculator
    {
        public static double Calc(string expression)
        {
            string source =
                @"
                using System;
 
                public static class Calculator
                {
                    public static double Calc()
                    {
                        return %expression%;
                    }
                }".Replace("%expression%", expression);

            // Настройки компиляции
            var compilerParams = new CompilerParameters { GenerateInMemory = true };
            // Компиляция
            var results = new CSharpCodeProvider().CompileAssemblyFromSource(compilerParams, source);
            //обработка ошибок
            if (results.Errors.Count > 0)
                throw new Exception(results.Errors[0].ErrorText);
            //получаем калькулятор
            var calculator = results.CompiledAssembly.GetType("Calculator");
            //считаем
            return (double)calculator.GetMethod("Calc").Invoke(null, null);
        }
    }

}
