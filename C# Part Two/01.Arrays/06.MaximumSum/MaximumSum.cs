// Write a program that reads two integer numbers N and K and an array of N elements from the console. 
// Find in the array those K elements that have maximal sum.

using System;

class MaximumSum
{
	static void Main()
	{
        int size = 0; // n
        int k = int.MaxValue;
        while (size <= 0)
        {
            Console.Write("Enter the size of the array: ");
            size = int.Parse(Console.ReadLine());
        }
        while (k > size)
        {
            Console.Write("Enter the number of integers you want the maximum sum of: ");
            k = int.Parse(Console.ReadLine());
        }

        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element {0} of the array: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);
        Console.WriteLine();
        int sum = 0;
        for (int i = size - 1; i >= (size - k); i--)
        {
            Console.Write(numbers[i]);
            if (i != (size - k))
            {
                Console.Write(" + ");
            }
            sum += numbers[i];
        }

        Console.WriteLine(" = {0}\n", sum);
	}
}

