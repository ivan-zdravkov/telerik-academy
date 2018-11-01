// Write a method that counts how many times given number appears in given array. 
// Write a test program to check if the method is working correctly.
using System;

class TimesInArray
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
        Console.Write("The array will be filled with numbers in the interval [0, X]. ");
        size = 0;
        while (size < 1)
        {
            Console.Write("Enter X: ");
            size = int.Parse(Console.ReadLine());
        }

        Console.Write("Generating random numbers in the array... ");
        Random rnd = new Random();
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(0, 100); 
        }
        Console.WriteLine("DONE.");

        int numberToBeFound;
        Console.Write("\nEnter which number you are looking for: ");
        numberToBeFound = int.Parse(Console.ReadLine());
        int numberOfTimes = inArray(array, numberToBeFound);
        Console.WriteLine("{0} is found {1} times in the array!\n", numberToBeFound, numberOfTimes);

        Console.Write("\nDo you want to print the array[y/n]: ");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        while (keyInfo.Key != ConsoleKey.Y && keyInfo.Key != ConsoleKey.N)
        {
            Console.Write("\nDo you want to print the array[y/n]: ");
            keyInfo = Console.ReadKey();
        }
        Console.WriteLine();
        if (keyInfo.Key == ConsoleKey.Y)
        {  
            PrintArray(array);
        }
    }

    static int inArray(int[] array, int number)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                count++;
            }
        }
        return count;
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
