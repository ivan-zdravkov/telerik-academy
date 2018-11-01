// Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

class MinMaxInteger
{
	static void Main()
	{
        int size = 0;
        while (size < 1)
        {
            Console.Write("Enter the size of the array of integers: ");
            size = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Please enter {0} integers: ", size);
        int[] numbers = new int[size];
        /*foreach (int element in numbers)
        {
            Console.Write("Please enter an integer: ");
            numbers[element] = int.Parse(Console.ReadLine());
        }*/
        for(int i = 0; i < size; i++)
        {
            Console.Write("Please enter numbers[{0}]: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int min = int.MaxValue;
        int max = int.MinValue;
        for (int i = 0; i < size; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        Console.WriteLine("The minimum number is: {0}\nThe maximum number is: {1}", min, max);
	}
}

