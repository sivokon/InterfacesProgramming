using Lab2_Calculator.Services;

namespace Lab2_Calculator
{
    public class ArithmeticOperation
    {
        private double _firstOperator;
        private double _secondOperator;
        private Ops _operation;

        public ArithmeticOperation(double firstOperator, Ops operation, double secondOperation)
        {
            _firstOperator = firstOperator;
            _secondOperator = secondOperation;
            _operation = operation;
        }

        public double Execute()
        {
            switch (_operation)
            {
                case Ops.Add: return _firstOperator + _secondOperator;
                case Ops.Subtract: return _firstOperator - _secondOperator;
                case Ops.Multiply: return _firstOperator * _secondOperator;
                case Ops.Devide: return _firstOperator / _secondOperator;
                default: return _firstOperator + _secondOperator;
            }
        }

        public double Execute(ArithmeticOperation operation, Ops sign, double secondOperand)
        {
            switch (_operation)
            {
                case Ops.Add: return operation.Execute() + _secondOperator;
                case Ops.Subtract: return operation.Execute() - _secondOperator;
                case Ops.Multiply: return operation.Execute() * _secondOperator;
                case Ops.Devide: return operation.Execute() / _secondOperator;
                default: return operation.Execute() + _secondOperator;
            }
        }

        public double Execute(double firstOperand, Ops sign, ArithmeticOperation operation)
        {
            switch (_operation)
            {
                case Ops.Add: return operation.Execute() + operation.Execute();
                case Ops.Subtract: return operation.Execute() - operation.Execute();
                case Ops.Multiply: return operation.Execute() * operation.Execute();
                case Ops.Devide: return operation.Execute() / operation.Execute();
                default: return operation.Execute() + operation.Execute();
            }
        }

        public double Execute(ArithmeticOperation operation1, Ops sign, ArithmeticOperation operation2)
        {
            switch (_operation)
            {
                case Ops.Add: return operation1.Execute() + operation2.Execute();
                case Ops.Subtract: return operation1.Execute() - operation2.Execute();
                case Ops.Multiply: return operation1.Execute() * operation2.Execute();
                case Ops.Devide: return operation1.Execute() / operation2.Execute();
                default: return operation1.Execute() + operation2.Execute();
            }
        }



    }
}
