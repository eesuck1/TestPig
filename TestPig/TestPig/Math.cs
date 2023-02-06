using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPig
{
    internal class Math
    {
        public double Sum(params double[] numbers)
        {
            double result = 0;

            foreach (double number in numbers)
            {
                result += number;
            }

            return result;
        }

        public int Factorial(int number)
        {
            if (number <= 1) return 1;

            return number * Factorial(number - 1);
        }
    }
}
