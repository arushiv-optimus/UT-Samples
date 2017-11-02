using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class CalculatorOperation
    {
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result; 
        }

        public int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        public int Divide(int numerator, int denominator)
        {
            return numerator / denominator;

        }

    }
}
