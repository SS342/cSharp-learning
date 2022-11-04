using System;


namespace ConsoleApp1
{
    internal static class Program
    {
        private static void Main()
        {
            string password;
            Console.WriteLine("Введите ваше пароль:");
            password = Console.ReadLine()!;
            if (CheckPassword(password))
            {
                Console.WriteLine("Good");
            }
            else
            {
                Console.WriteLine(":(");
            }
        }

        static bool CheckPassword(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
