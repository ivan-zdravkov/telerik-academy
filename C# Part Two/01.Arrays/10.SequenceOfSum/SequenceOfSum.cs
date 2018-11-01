// Write a program that finds in given array of integers a sequence of given sum S (if present). 
// Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
using System;

class SequenceOfSum
{
    static void Main()
    {
        //int[] array = { 4, 3, 1, 4, 2, 5, 8 };
        //int s = 11;

        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element {0} of the array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the sum you would like to find: ");
        int s = int.Parse(Console.ReadLine());

        int startPossition = 0;
        int sizeOfStack = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int sum = 0;
            sizeOfStack = 0;
            for (int j = i; j < array.Length && sum != s; j++)
            {
                sum += array[j];
                sizeOfStack++;
            }
            if (sizeOfStack == 1 && sum != s)
            {
                sizeOfStack = 0;
                break;
            }
            if (sum == s)
            {
                startPossition = i;
                break;
            }
        }
        if (sizeOfStack == 0)
        {
            Console.WriteLine("There is no stack with this sum!");
        }
        else
        {
            Console.Write("The stack that has sum {0} is ", s);
            Console.Write("{");
            for (int i = startPossition; i < startPossition + sizeOfStack; i++)
            {
                Console.Write(array[i]);
                if (i != startPossition + sizeOfStack - 1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine("}");
                }
            }
        }
    }
}

