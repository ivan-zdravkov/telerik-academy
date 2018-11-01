// Write a program, that reads from the console an array of N integers and an integer K, 
// sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class BinSearch
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

        Console.Write("Enter the number you are looking for: ");
        int requestedNumber = int.Parse(Console.ReadLine());

        quickSort(numbers, 0, (size - 1));
        Print(numbers);

        int answer = Array.BinarySearch(numbers, requestedNumber);
        if ((answer >= 0) && (numbers[answer] == requestedNumber))
        {
            Console.WriteLine("The largest number that is equal to or less than {0} is Array[{1}] = {2}", requestedNumber, answer, numbers[answer]);
        }
        else if (answer == -1)
        {
            Console.WriteLine("There is no number that is equal to or less than {0} in the array!", requestedNumber);
        }
        else if (answer < -1)
        {
            answer += 2;
            answer *= -1;
            Console.WriteLine("The largest number that is equal to or less than {0} is Array[{1}] = {2}", requestedNumber, answer, numbers[answer]);
        }
    }


    static void quickSort(int[] A, int start, int stop)
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
            quickSort(A, start, j);
        if (i < stop)
            quickSort(A, i, stop);
    }

    static void Print(int[] arrayToPrint)
    {
        Console.Write("{" + " ");
        for (int i = 0; i < arrayToPrint.Length; i++)
        {
            Console.Write(arrayToPrint[i]);
            if (i != arrayToPrint.Length - 1)
            {
                Console.Write(", ");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine("}");
    }
}

