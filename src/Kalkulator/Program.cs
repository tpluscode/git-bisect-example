using System;

namespace Kalkulator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal? result;

            if (args.Length == 3)
            {
                var op = args[1];
                var left = decimal.Parse(args[0]);
                var right = decimal.Parse(args[2]);
                result = CalculateBinary(op, left, right);
            }
            else if (args.Length == 2)
            {
                var op = args[0];
                result = CalculateUnary(op, args[1]);
            }
            else
            {
                Console.WriteLine("Złe argumenty");
                return;
            }

            Console.WriteLine($"Wynik: {result}");
        }

        private static decimal? CalculateUnary(string op, string operand)
        {
            switch (op)
            {
                case "sqrt":
                    return (decimal)Math.Sqrt(double.Parse(operand));
                case "ln":
                    return (decimal)Math.Log(double.Parse(operand));
            }

            return null;
        }

        private static decimal? CalculateBinary(string op, decimal left, decimal right)
        {
            switch (op)
            {
                case "+":
                    return left + right;
                case "-":
                    return left + right;
                case "*":
                    return left * right;
                case "/":
                    return left / right;
            }

            return null;
        }
    }
}
