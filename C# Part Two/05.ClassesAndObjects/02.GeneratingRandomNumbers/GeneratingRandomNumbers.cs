// Write a program that generates and prints to the console 10 random values in the range [100, 200].
using System;

class GeneratingRandomNumbers
{
    public static Random integerGenerator = new Random();

    static void Main(string[] args)
    {
        int[] array = GenerateRandomNumbers(integerGenerator, 10, 100, 200);
        Print(array);
    }

    static int[] GenerateRandomNumbers(Random generator, int sizeOfArray, int minRange, int maxRange)
    {
        int[] array = new int[sizeOfArray];
        for (int i = 0; i < sizeOfArray; i++)
        {
            array[i] = generator.Next(minRange, maxRange);
        }
        return array;
    }

    static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
