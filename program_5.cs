using System;


namespace ConsoleApp1
{
    internal static class Program
    {
        private static void Main()
        {
           short num1, num2;
           num1 = 10;
           num2 = 15;
           Console.WriteLine("{0} + {1} = {2}", num1, num2, Sum(num1, num2)); // типа как f-строка в питоне
        }

        static int Sum(int x, int y) // функция которая вовращает инт
        {
            return x + y;
        }
    }
}
