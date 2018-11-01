// * Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. 
// Example: n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}


using System;

class Permutations
{
    static int counter = 1;

    static void Main(string[] args)
    {
        int n = 0;
        while (n < 1)
        {
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());
        }

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = i + 1;
        }
        Permutation(array, 0, array.Length - 1);
    }

    static void Permutation(int[] array, int current, int length)
    {
        if (current == length)
        {
            Console.WriteLine("{0}", string.Join(", ", array));
            counter++;
        }
        else
        {
            for (int i = current; i <= length; i++)
            {
                Switch(ref array[i], ref array[current]);
                Permutation(array, current + 1, length);
                Switch(ref array[i], ref array[current]);
            }
        }
    }

    static void Switch(ref int first, ref int second)
    {
        int temp = first;
        first = second;
        second = temp;
    }
}

