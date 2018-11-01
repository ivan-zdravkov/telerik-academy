// Write a method that checks if the element at given position in given array of integers 
// is bigger than its two neighbors (when such exist).

using System;

class BiggerThanTwoNeighbours
{
    static void Main()
    {
        int size = 0;
        while (size < 1)
        {
            Console.Write("Enter the size of the array: ");
            size = int.Parse(Console.ReadLine());
        }

        int[] array = GenerateArray(size);

        Console.Write("\n\nPlease enter the possition you would like to check: ");
        int possition = int.Parse(Console.ReadLine());

        if (possition >= array.Length || possition < 0)
        {
            Console.WriteLine("The selected possition is not in the array");
        }
        else
        {
            bool conditionMet = isBigger(array, possition);
            Console.WriteLine("The number in the selected possition is {0} than its neighbours!", conditionMet ? "bigger" : "not bigger");
        }
    }

    static int[] GenerateArray(int size)
    {
        Console.WriteLine("Generating random array...");
        Random rnd = new Random();
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(-100, 100);
            Console.WriteLine("array[{0}] = {1}", i, array[i]);
        }
        return array;
    }

    static bool isBigger(int[] array, int possition)
    {
        if (possition == 0)
        {
            if (array[0] > array[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (possition == array.Length - 1)
        {
            if (array[array.Length - 1] > array[array.Length - 2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            if ((array[possition] > array[possition - 1]) && (array[possition] > array[possition + 1]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

