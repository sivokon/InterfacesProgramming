using Lab2_Calculator.models;
using System;

namespace Lab2_Calculator
{
    public class CalculatorService
    {
        public CalculatorService()
        {

        }

        public double GetOperationResult(double firstOperand, double secondOperand, string operation)
        {
            var result = 0.0;

            switch (operation)
            {
                case "+":
                    result = firstOperand + secondOperand;
                    break;
                case "-":
                    result = firstOperand - secondOperand;
                    break;
                case "*":
                    result = firstOperand * secondOperand;
                    break;
                case "/":
                    result = firstOperand / secondOperand;
                    break;
                case "Mod":
                    result = firstOperand % secondOperand;
                    break;
                case "Exp":
                    result = Math.Sqrt(firstOperand);
                    break;
            }

            return result;
        }

        //public double 

        //public double GetOperationResult(ArithmeticOperation arithmeticOperation)
        //{
        //    var result = 0.0;

        //    switch (arithmeticOperation.Operation)
        //    {
        //        case "+":
        //            result = arithmeticOperation.FirstOperand + arithmeticOperation.SecondOperand;
        //            break;
        //        case "-":
        //            result = arithmeticOperation.FirstOperand - arithmeticOperation.SecondOperand;
        //            break;
        //        case "*":
        //            result = arithmeticOperation.FirstOperand * arithmeticOperation.SecondOperand;
        //            break;
        //        case "/":
        //            result = arithmeticOperation.FirstOperand / arithmeticOperation.SecondOperand;
        //            break;
        //    }

        //    return result;
        //}

    }
}
