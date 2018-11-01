// Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

using System;

class MergeSort
{
    static void Main()
    {
        int size = 0;
        while (size < 1)
        {
            Console.Write("Enter the size of the array: ");
            size = int.Parse(Console.ReadLine());
        }

        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element {0} of array: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        numbers = MSort(numbers); // en.wikipedia.org/wiki/Merge_sort

        Console.WriteLine("The sorted array is: ");
        foreach (int element in numbers)
        {
            Console.WriteLine(element);
        }
    }

    // Merge sort splits the current array in every reccursion and then unites it when it exists the reccursion.
    // Reccursion is a very interesting technique, which we haven't studied yet
    // en.wikipedia.org/wiki/Recursion
    static int[] MSort(int[] arrayToSort) // MergeSort name already taken by class name
    {
        if (arrayToSort.Length == 1)
        {
            return arrayToSort;
        }
        int middle = arrayToSort.Length / 2;
        int[] left = new int[middle];
        for (int i = 0; i < middle; i++)
        {
            left[i] = arrayToSort[i];
        }
        int[] right = new int[arrayToSort.Length - middle];
        for (int i = 0; i < arrayToSort.Length - middle; i++)
        {
            right[i] = arrayToSort[i + middle];
        }

        left = MSort(left);
        right = MSort(right);

        int leftPointer = 0;
        int rightPointer = 0;

        int[] sorted = new int[arrayToSort.Length];
        for (int k = 0; k < arrayToSort.Length; k++)
        {
            if (rightPointer == right.Length || ((leftPointer < left.Length) && (left[leftPointer] <= right[rightPointer])))
            {
                sorted[k] = left[leftPointer];
                leftPointer++;
            }
            else if (leftPointer == left.Length || ((rightPointer < right.Length) && (right[rightPointer] <= left[leftPointer])))
            {
                sorted[k] = right[rightPointer];
                rightPointer++;
            }
        }
        return sorted;
    }
}

