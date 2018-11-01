// Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
// Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

class Variations
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
        Variation(set, 0, n);
    }

    static void Variation(int[] array, int index, int numberOfElements)
    {
        if (index != array.Length)
        {
            for (int i = 1; i <= numberOfElements; i++)
            {
                array[index] = i;
                Variation(array, index + 1, numberOfElements);
            }
        }
        else
        {
            PrintArray(array);
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

