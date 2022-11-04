using System;


namespace ConsoleApp1
{
    internal static class Program
    {
        private static void Main()
        {
            
            string name; // создаем переменную типа строки
            Console.WriteLine("Введите ваше имя: ");
            name = Console.ReadLine(); // считываем с консоли строку
            Console.WriteLine("Ваше имя - {0}", name); // выводим
            
        }
    }
}
