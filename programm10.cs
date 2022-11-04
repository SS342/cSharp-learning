using System;


namespace ConsoleApp1
{
    internal static class Program
    {
        private static void Main()
        {
            int a, b;
            string _operator;
            Int32.TryParse(Console.ReadLine(), out a);
            Int32.TryParse(Console.ReadLine(), out b);
            _operator = Console.ReadLine();

            Console.WriteLine(do_primer(a, b ,_operator));

        }

        static int Plus(int a, int b)
        {
            return a + b;
        }

        static int Minus(int a, int b)
        {
            return a - b;
        }

        static int Mult(int a, int b)
        {
            return a * b;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }
        static int do_primer(int a, int b, string oper)
        {
            switch (oper)
            {
                case "+":
                    return Plus(a, b);
                case "-":
                    return Minus(a, b);
                case "*":
                    return Mult(a, b);
                case "/":
                    return Divide(a, b);
                default:
                    return 0;
            }
        }
    }
}
