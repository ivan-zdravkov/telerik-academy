// Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
// NB! This task is the same as task 07.SortingAnArray. I did 07, before knowing I have to implement the 
//     QuickSort later on, so I did 07, with QuickSort as a sorting algorithm of choice.

using System;

class QuickSort
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

        QSort(numbers, 0, (size - 1)); // en.wikipedia.org/wiki/Quicksort
        Print(numbers);
    }


    static void QSort(int[] A, int start, int stop) // QSort, since QuickSort is already taken by class name
    {
        int i, j, m, temp;
        m = A[(start + stop) / 2];
        i = start;
        j = stop;
        do
        {
            while (A[i] < m)
                i++;
            while (A[j] > m)
                j--;
            if (i <= j)
            {
                temp = A[i];
                A[i] = A[j];
                A[j] = temp;
                i++;
                j--;
            }
        } while (i <= j);

        if (j > start)
            QSort(A, start, j); // en.wikipedia.org/wiki/Recursion
        if (i < stop)
            QSort(A, i, stop); // en.wikipedia.org/wiki/Recursion
    }

    static void Print(int[] arrayToPrint)
    {
        for (int i = 0; i < arrayToPrint.Length; i++)
        {
            Console.WriteLine(arrayToPrint[i]);
        }
    }
}

