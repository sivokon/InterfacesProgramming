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

        private void standartToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Width = 272;
            userInput.Width = 234;
            btnEquals.Width = 234;
        }

        private void scientificToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Width = 530;
            userInput.Width = 491;
            btnEquals.Width = 491;
        }

        private void Method()
        {
            //Math.
        }
    }
}
