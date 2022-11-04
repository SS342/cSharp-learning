using System;


namespace ConsoleApp1
{
    internal static class Program
    {
        private static void Main()
        {
            int num1, num2;
            float f1, f2;
            num1 =13 /3;
            num2 =13 %3;
            f1 =13.0f /3.0f;
            f2 =13.0f %3.0f;
            Console.WriteLine("Результат и остаток от деления 13 на 3: {0} – {1}",num1, num2);
            Console.WriteLine("Результат деления 13.0 на 3.0: {0:#.###} {1}", f1, f2); 
        }
    }
}
