namespace Lab2_Calculator.models
{
    public class ArithmeticOperation
    {
        public double FirstOperand { get; set; }
        public double SecondOperand { get; set; }
        public string Operation { get; set; }

        public ArithmeticOperation(double firstOperand, double secondOperand, string operation)
        {
            FirstOperand = firstOperand;
            SecondOperand = secondOperand;
            Operation = operation;
        }

        public ArithmeticOperation(double operand, string operation)
        {
            FirstOperand = operand;
            Operation = operation;
        }

        public ArithmeticOperation()
        {
        }

        //public void OperationResult()
        //{

        //}

    }
}
