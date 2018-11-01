// 1. Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
//    and has the same functionality as Substring in the class String.

// 2. Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
//    sum, product, min, max, average.



using System;
using System.Text;

namespace Extentions
{
    class Program
    {
        public static Random generator = new Random();

        static void Main()
        {
            StringBuilder test = new StringBuilder();
            for (int i = 0; i < 20; i++)
            {
                test.Append(generator.Next(0, 100).ToString());
            }
            Console.WriteLine("Generating a random StringBuilder...");
            Console.WriteLine(test.ToString());
            Console.WriteLine("Printing elements [4, 14) of the 'test' StringBuilder...");
            Console.WriteLine(test.Substring(4, 10).ToString());

            int[] array = new int[20];
            Console.WriteLine("\nGenerating a random int array...");
            for (int i = 0; i < 20; i++)
            {
                array[i] = generator.Next(-99, 100);
            }
            Console.WriteLine(array.ToString<int>());
            Console.WriteLine();

            int sum = array.Sum<int>();
            Console.WriteLine("The SUM of the list elements is:     {0}", array.Sum<int>());
            Console.WriteLine("The PRODUCT of the list elements is: {0}", array.Product<int>());
            Console.WriteLine("The MIN of the list elements is:     {0}", array.Min<int>());
            Console.WriteLine("The MAX of the list elements is:     {0}", array.Max<int>());
            Console.WriteLine("The AVERAGE of the list elements is: {0}\n", array.Average<int>());
        }
    }
}
