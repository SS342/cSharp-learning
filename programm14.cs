using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{    
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random ran = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ran.Next(1, 20);
            }
            Console.WriteLine(array[0]);

        }
    }
}
