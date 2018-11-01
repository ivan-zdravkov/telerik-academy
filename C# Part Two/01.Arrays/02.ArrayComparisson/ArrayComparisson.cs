// Write a program that reads two arrays from the console and compares them element by element

using System;

class ArrayComparisson
{
	static void Main()
	{
        Console.Write("Enter the size of the arrays: ");
        int size = int.Parse(Console.ReadLine());
        int[] arrayOne = new int[size];
        int[] arrayTwo = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element {0} of array ONE: ", i);
            arrayOne[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element {0} of array TWO: ", i);
            arrayTwo[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        for (int i = 0; i < size; i++)
        {
            Console.Write("[{0}] -> {1}", i, arrayOne[i]);
            if (arrayOne[i] == arrayTwo[i])
            {
                Console.Write(" = ");
            }
            else
            {
                if (arrayOne[i] > arrayTwo[i])
                {
                    Console.Write(" > ");
                }
                else
                {
                    Console.Write(" < ");
                }
            }
            Console.WriteLine(arrayTwo[i]);
        }
	}
}

