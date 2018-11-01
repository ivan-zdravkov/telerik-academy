// Sorting an array means to arrange its elements in increasing order. 
// Write a program to sort an array. Use the "selection sort" algorithm: 
// Find the smallest element, move it at the first position, 
// find the smallest from the rest, move it at the second position, etc.

using System;

class SortingAnArray
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

        quickSort(numbers, 0, (size - 1)); // en.wikipedia.org/wiki/Quicksort
        Print(numbers);
	}


    static void quickSort(int[] A, int start, int stop)
    {
	    int i, j, m, temp;
        m = A[(start+stop)/2];	
        i = start;
        j = stop;
        do
        {
	        while(A[i] < m)
		        i++;
	        while(A[j] > m)
		        j--;
	        if(i <= j)
	        {
		        temp = A[i];
		        A[i] = A[j];
		        A[j] = temp;
		        i++;
		        j--;
	        }
        } while (i <= j);
        
        if(j > start)
            quickSort(A, start, j); // en.wikipedia.org/wiki/Recursion
        if(i < stop)
            quickSort(A, i, stop); // en.wikipedia.org/wiki/Recursion
    }

    static void Print(int[] arrayToPrint)
    {
        for (int i = 0; i < arrayToPrint.Length; i++)
        {
            Console.WriteLine(arrayToPrint[i]);
        }
    }
}

