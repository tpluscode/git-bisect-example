using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Kalkulator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal result;
            var op = args[1];
            var left = decimal.Parse(args[0]);
            var right = decimal.Parse(args[2]);

            result = CalculateBinary(op, left, right);

            Console.WriteLine($"Wynik: {result}");
        }

        private static decimal CalculateBinary(string op, decimal left, decimal right)
        {
            decimal result = 0;

            switch (op)
            {
                case "+":
                    result = left + right;
                    break;
                case "-":
                    result = left + right;
                    break;
                case "*":
                    result = left * right;
                    break;
                case "/":
                    result = left / right;
                    break;
            }

            return result;
        }
    }
}
