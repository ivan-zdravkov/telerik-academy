// Write a method that return the maximal element in a portion of array of integers starting at given index. 
// Using it write another method that sorts an array in ascending / descending order.

using System;

class MaximumElementSort
{
    static void Main()
    {
        int size = 0;
        while (size < 1)
        {
            Console.Write("Enter the size of the array: ");
            size = int.Parse(Console.ReadLine());
        }
        int[] array = new int[size];

        Console.WriteLine("Generating random array...");
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(-100, 100);
        }
        Console.WriteLine("Done");

        PrintArray(array);
        MaxElementSort(array);
        PrintArray(array);
    }

    static void MaxElementSort(int[] array)
    {
        int[] sortedArray = new int[array.Length];
        int tempMaxElement = 0;
        int exchange = 0;
        for (int i = 0; i < array.Length; i++)
        {
            tempMaxElement = MaximumElement(array, i);
            sortedArray[i] = array[tempMaxElement];
            exchange = array[tempMaxElement];
            array[tempMaxElement] = array[i];
            array[i] = exchange;
        }
        array = sortedArray;
    }

    static int MaximumElement(int[] array, int startIndex)
    {
        int maxElementValue = int.MinValue;
        int maxElementIndex = 0;
        for (int i = startIndex; i < array.Length; i++)
        {
            if (array[i] > maxElementValue)
            {
                maxElementValue = array[i];
                maxElementIndex = i;
            }
        }
        return maxElementIndex;
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

