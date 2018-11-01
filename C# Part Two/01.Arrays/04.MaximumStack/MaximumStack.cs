// Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

using System;

class MaximumStack
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

        int maximumStack = 1; // The maximum stack size
        int currentStack = 1; // The current stack size
        int stackValue = 0; // The value of the maximum stack

        for (int i = 0; i < size - 1; i++)
        { 
            if (array[i] == array[i + 1])
            {
                currentStack++;
                if (currentStack >= maximumStack)
                {
                    maximumStack = currentStack;
                    stackValue = array[i];
                }
            }
            else
            {
                if (currentStack >= maximumStack)
                {
                    maximumStack = currentStack;
                    stackValue = array[i];
                }
                currentStack = 1; // Reset the current stack data if the next one is not equal to the current number
            }
        }

        Console.WriteLine();
        if (maximumStack == 1)
        {
            Console.WriteLine("There isn't a stack in this array!");
        }
        else
        {
            Console.Write("The maximum stack is {0} elements long and is the following ( ", maximumStack);
            for (int i = 0; i < maximumStack; i++)
            {
                Console.Write(stackValue);
                if (i != (maximumStack - 1))
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" )");
        }
        Console.WriteLine();
	}
}

