// Write a program that reads an integer number n from the console and prints all the numbers in the interval 
// [1..n], each on a single line.

using System;

class IntervalN
{
    static void Main()
    {
        Console.Write("Enter n: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine("All the integers in the interval [1, {0}] are: ", n);
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

