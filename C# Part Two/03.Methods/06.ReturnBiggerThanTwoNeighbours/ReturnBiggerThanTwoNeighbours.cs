// Write a method that returns the index of the first element in array that is bigger than its neighbors, 
// or -1, if there’s no such element.
using System;

class ReturnBiggerThanTwoNeighbours
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

        int index = GetIndex(array);

        if (index == -1)
        {
            Console.WriteLine("There is no element that is bigger than its neighbours");
        }
        else
        {
            Console.WriteLine("The index of the first element that is bigger than its neighbours is {0}", index);
        }
    }

    private static int GetIndex(int[] array)
    {
        for (int possition = 0; possition < array.Length; possition++)
        {
            bool conditionMet = isBigger(array, possition);
            if (conditionMet)
            {
                return possition;
            }
        }
        return -1;
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

