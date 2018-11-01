// Write a program that finds the index of given element in a sorted array 
// of integers by using the binary search algorithm (find it in Wikipedia).

using System;

class BinarySearch
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

        QuickSort(numbers, 0, (size - 1)); // en.wikipedia.org/wiki/Quicksort
        Print(numbers);
        Console.Write("Enter the number, whose possition, you are searching for: ");
        int numberToFind = int.Parse(Console.ReadLine());
        int index = BinSearch(numbers, size, numberToFind); // en.wikipedia.org/wiki/Binary_search_algorithm
        if (index == -1)
        {
            Console.WriteLine("The requested number is not in the array!");
        }
        else
        {
            Console.WriteLine("The index of the requested number {0} is {1}", numberToFind, index);
        }
	}

    static int BinSearch(int[] sortedArray, int sizeOfArray, int numberToBeFound) // BinarySearch name already taken by Class name
    {
	    int left = 0;
        int right = sizeOfArray - 1;
        int Found = 0;
        int k = 0;
	    while (left <= right)
	    {
		    k = (left + right ) / 2;
            if (sortedArray[k] == numberToBeFound) 
		    {
			    Found = 1; 
			    break;
		    }
            if (sortedArray[k] > numberToBeFound) 
            {
			    right = k - 1; 
            }
		    else 
            {
			    left = k + 1;
            }
	    }
        if (Found == 1)
        {
            return k;
        }
        else
        {
            return -1;
        }
    }

    static void QuickSort(int[] arrayToSort, int start, int stop) // en.wikipedia.org/wiki/Quicksort
    {
	    int i;
        int j;
        int mediane;
        int temp;
        mediane = arrayToSort[(start + stop) / 2];	
        i = start;
        j = stop;
        do
        {
            while (arrayToSort[i] < mediane)
		        i++;
            while (arrayToSort[j] > mediane)
		        j--;
	        if(i <= j)
	        {
                temp = arrayToSort[i];
                arrayToSort[i] = arrayToSort[j];
                arrayToSort[j] = temp;
		        i++;
		        j--;
	        }
        } while (i <= j);
        
        if(j > start)
            QuickSort(arrayToSort, start, j); // Recurrsion
        if(i < stop)
            QuickSort(arrayToSort, i, stop); // Recurrsion
    }

    static void Print(int[] arrayToPrint)
    {
        for (int i = 0; i < arrayToPrint.Length; i++)
        {
            Console.WriteLine(arrayToPrint[i]);
        }
    }
}

