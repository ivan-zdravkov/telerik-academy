// Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. 
// Example: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;
using System.Collections.Generic;

class Combinations
{
    static void Main()
    {
        int n = 0;
        int k = 0;
        while (n < 1)
        {
            Console.Write("Enter N: ");
            n = int.Parse(Console.ReadLine());
        }
        while (k < 1)
        {
            Console.Write("Enter K: ");
            k = int.Parse(Console.ReadLine());
        }

        int[] set = new int[k];
        Combination(set, 0, 1, n);
    }

    static void Combination(int[] array, int index, int currentNumber, int numberOfElements)
    {
        if (index == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = currentNumber; i <= numberOfElements; i++)
            {
                array[index] = i;
                Combination(array, index + 1, i + 1, numberOfElements);
            }
        }
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

