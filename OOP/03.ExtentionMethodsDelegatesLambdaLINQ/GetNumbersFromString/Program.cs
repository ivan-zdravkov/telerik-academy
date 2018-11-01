// 6. Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//    Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

using System;
using System.Linq;

namespace GetNumbersFromString
{
    class Program
    {
        static Random generator = new Random();

        static void Main()
        {
            int length = generator.Next(100, 200);
            int[] intArray = new int[length];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = generator.Next(-99, 100);
            }

            int click = 1;
            foreach (int number in intArray)
            {
                Console.Write("{0,3}, ", number);
                if (click < 10)
                {
                    click++;
                }
                else
                {
                    Console.WriteLine();
                    click = 1;
                }
            }

            Console.WriteLine("\n\n[Lambda]Printing all the numbers, devisable by 3 and 7...");
            var devidable = intArray.Where(number => (number % 3 == 0) && (number % 7 == 0));
            foreach (int number in devidable)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\n\n[LINQ]Printing all the numbers, devisable by 3 and 7...");
            devidable =
                from number in intArray
                where (number % 3 == 0) && (number % 7 == 0)
                orderby number
                select number;
            foreach (int number in devidable)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
        }
    }
}
