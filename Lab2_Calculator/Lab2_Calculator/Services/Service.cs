using System.Collections.Generic;
using System.Linq;

namespace Lab2_Calculator.Services
{
    public enum Operations
    {
        Add,
        Subtract,
        Multiply,
        Devide
    }

    public class Service
    {
        public Service()
        {

        }

        public string Calculate(string[] userInput)
        {
            if (!double.TryParse(userInput[userInput.Length - 1], out var lastElement))
            {
                return string.Empty;
            }

            var numbers = new List<double>();
            var operations = new List<string>();

            for (int i = 0; i < userInput.Length; i++)
            {
                if (i % 2 == 0)
                {
                     numbers.Add(double.Parse(userInput[i]));
                }
            }

            for (int i = 0; i < userInput.Length; i++)
            {
                if (i % 2 == 1)
                {
                    operations.Add(userInput[i]);
                }
            }

            List<double> finalNumbers = new List<double>();
            double first = 0;
            double res = 0;
            bool wasMinus = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i != 0)
                {
                    if (operations[i - 1] == "x" || operations[i - 1] == "/")
                    {
                        if (operations[i - 1] == "x") res = first * numbers[i];
                        else if (operations[i - 1] == "/") res = first / numbers[i];
                        if (i != numbers.Count - 1)
                        {
                            if (operations[i] == "x" || operations[i] == "/")
                            {
                                first = res;
                                continue;
                            }
                        }
                        if (wasMinus) res = res * -1;
                        finalNumbers.Add(res);
                        wasMinus = false;
                        first = 0;
                        continue;
                    }
                }
                if (i != numbers.Count - 1)
                {
                    if (operations[i] == "+" || operations[i] == "-")
                    {
                        if (i != 0)
                        {
                            if (operations[i - 1] == "-")
                            {
                                finalNumbers.Add(numbers[i] * -1);
                                continue;
                            }
                        }
                        finalNumbers.Add(numbers[i]);
                    }
                    else if (operations[i] == "x" || operations[i] == "/")
                    {
                        if (i != 0)
                        {
                            if (operations[i - 1] == "-") wasMinus = true;
                        }
                        if (first == 0) first = numbers[i];
                    }
                }
                else
                {
                    if (operations[i - 1] == "+") finalNumbers.Add(numbers[i]);
                    else if (operations[i - 1] == "-") finalNumbers.Add(numbers[i] * -1);
                }
            }

            return finalNumbers.Sum().ToString();
        }



        private void Trash()
        {
            //REDUNDANT FOR NOW
            //double temp = 0;
            //for (int i = 0; i < userInput.Length; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        if (!double.TryParse(userInput[userInput.Length - 1], out temp))
            //        {
            //            return string.Empty;
            //        }
            //    }
            //}
        }

    }
}
