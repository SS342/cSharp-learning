using System;


namespace ConsoleApp1
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello world!");
            int a; // обьявили переменную
            a = 10; // присвоили ей значение

            int b = 15; // или сразу так

            char sumbol = 'q'; // символ - одиночный кавычки, на двойные ругается
            float pi = 3.14F; // число пи, буква F на конце флоат - обязательна

            int x = 5, y = 6, z = 7; // можно объявлять переменные сразу так
            
            // Возможность самому определить тип локальной переменной, исходя из значения, которым она инициализируется

            var c = 10;
            var e = 3.15F;
            
            // Константы
            const int hyi_width = 100;
        }
    }
}
