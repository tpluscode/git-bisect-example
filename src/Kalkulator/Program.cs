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
            object result = null;
            var op = args[1];
            var left = decimal.Parse(args[0]);
            var right = decimal.Parse(args[2]);

            switch (op)
            {
                case "+":
                    result = left + right;
                    break;
                case "-":
                    result = left - right;
                    break;
                case "*":
                    result = left * right;
                    break;
                case "/":
                    result = left / right;
                    break;
            }

            Console.WriteLine($"Wynik: {result}");
        }
    }
}
