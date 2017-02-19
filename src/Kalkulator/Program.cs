using System;

namespace Kalkulator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal? result = null;

            if (args.Length == 3)
            {
                var op = BinaryOperation.Parse(args);
                result = CalculateBinary((dynamic)op);
            }
            else if (args.Length == 2)
            {
                var op = args[0];
                result = CalculateUnary(op, args[1]);
            }

            if (result == null)
            {
                Console.WriteLine("Złe argumenty");
            }
            else
            {
                Console.WriteLine($"Wynik: {result}");
            }
        }

        private static decimal? CalculateUnary(string op, string operand)
        {
            var value = double.Parse(operand);

            switch (op)
            {
                case "sqrt":
                    return (decimal)Math.Sqrt(value);
                case "ln":
                    return (decimal)Math.Log(value);
                case "sin":
                    return (decimal)Math.Sin(value);
            }

            return null;
        }

        private static decimal? CalculateBinary(BinaryOperation<double, double> operation)
        {
            return (decimal)Math.Log(operation.Right, operation.Left);
        }

        private static decimal? CalculateBinary(BinaryOperation<decimal, decimal> operation)
        {
            switch (operation.Operator)
            {
                case "+":
                    return operation.Left + operation.Right;
                case "-":
                    return operation.Left + operation.Right;
                case "*":
                    return operation.Left * operation.Right;
                case "/":
                    return operation.Left / operation.Right;
            }

            return null;
        }
    }

    public class BinaryOperation
    {
        protected BinaryOperation(string @operator)
        {
            Operator = @operator;
        }

        public string Operator { get; }

        public static BinaryOperation Parse(string[] args)
        {
            if (args[0] == "log")
            {
                return new BinaryOperation<double, double>(args[0], double.Parse(args[1]), double.Parse(args[2]));
            }

            return new BinaryOperation<decimal, decimal>(args[1], decimal.Parse(args[0]), decimal.Parse(args[2]));
        }
    }

    public class BinaryOperation<TLeft, TRight> : BinaryOperation
    {
        public BinaryOperation(string @operator, TLeft left, TRight right) : base(@operator)
        {
            Left = left;
            Right = right;
        }

        public TLeft Left { get; }

        public TRight Right { get; }
    }
}
