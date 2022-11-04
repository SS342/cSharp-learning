using System;


namespace ConsoleApp1
{
    internal static class Program
    {
        private static void Main()
        {
            int premission = 0;
            string name; // создаем переменную типа строки
            string password; // создаем переменную типа строки
            Console.WriteLine("Введите ваше имя: ");
            name = Console.ReadLine()!; // считываем с консоли строку
            
            Console.WriteLine("Введите ваш пароль: ");
            password = Console.ReadLine()!; // считываем с консоли строку
            
            if (name == "allelleo")
            {
                premission++;
            }

            if (password == "allelleo")
            {
                premission++;
            }

            if (premission == 2)
            {
                Console.WriteLine("Доступ разрешен");
            }
            else
            {
                Console.WriteLine("Доступ запрещен");
            }
        }
    }
}
