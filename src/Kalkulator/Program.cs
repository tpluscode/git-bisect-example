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
            decimal? result = null;

            if (args.Length == 3)
            {
                var op = args[1];
                var left = decimal.Parse(args[0]);
                var right = decimal.Parse(args[2]);
                result = CalculateBinary(op, left, right);
            }
            else if(args.Length == 2)
            {
                var op = args[0];
                var operand = decimal.Parse(args[1]);
                result = CalculateUnary(op, operand);
            }

            Console.WriteLine($"Wynik: {result}");
        }

        private static decimal? CalculateUnary(string op, object operand)
        {
            throw new NotImplementedException();
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
