// Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

using System;

class IncreasingStack
{
	static void Main()
	{
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element {0} of the array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int maximumStackPossition = 0; // The starting possition of the biggest stack
        int maximumStackSize = 1; // The size of the biggest stack
        int currentStackPossition = 0; // The starting possition of the current stack
        int currentStackSize = 1; // The size of the current stack

        for (int i = 0; i < size - 1; i++)
        { 
            if (array[i] == array[i + 1] - 1) // Check if the next number is (+1)
            {
                if (currentStackSize == 1)
                {
                    currentStackPossition = i;
                }
                currentStackSize++;
                if (currentStackSize >= maximumStackSize)
                {
                    maximumStackSize = currentStackSize;
                    maximumStackPossition = currentStackPossition;
                }
            }
            else
            {
                if (currentStackSize >= maximumStackSize)
                {
                    maximumStackSize = currentStackSize;
                    maximumStackPossition = currentStackPossition;
                }
                currentStackPossition = 0; // Reset the current stack data if the next number is not (+1)
                currentStackSize = 1;
            }
        }

        Console.WriteLine();
        if (maximumStackSize == 1)
        {
            Console.WriteLine("There isn't a stack in this array!");
        }
        else
        {
            Console.Write("The maximum stack is {0} elements long and is the following ( ", maximumStackSize);
            for (int i = maximumStackPossition; i < maximumStackPossition + maximumStackSize; i++)
            {
                Console.Write(array[i]);
                if (i != (maximumStackPossition + maximumStackSize - 1))
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" )");
        }
        Console.WriteLine();
	}
}