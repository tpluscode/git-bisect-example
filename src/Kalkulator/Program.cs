using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalkulator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var op = args[1];
            var left = decimal.Parse(args[0]);
            var right = decimal.Parse(args[2]);

            switch (op)
            {
                case "+":
                    Console.WriteLine(left + right);
                    break;
                case "-":
                    Console.WriteLine(left - right);
                    break;
                case "*":
                    Console.WriteLine(left * right);
                    break;
                case "/":
                    Console.WriteLine(left / right);
                    break;
            }
        }
    }
}
