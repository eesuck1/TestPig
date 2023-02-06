using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math calculator = new Math();

            Console.WriteLine(calculator.Multiplication(5, 2));

            Console.ReadKey();
        }
    }
}
