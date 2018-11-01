// Write a program that finds the sequence of maximal sum in given array. Example:
// {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
// Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class SequelMaximumSum
{
	static void Main()
	{
        /*Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element {0} of the array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }*/

        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        // Kadane's algorithm
        // en.wikipedia.org/wiki/Maximum_subarray_problem#Kadane.27s_algorithm

        int maxSoFar = array[0];
        int maxEndHere = array[0];
        int begin = 0;
        int beginTemp = 0;
        int end = 0;
        for (int i = 1; i < array.Length; i++)
        {
            maxEndHere += array[i];
            if (array[i] > maxEndHere)
            {
                maxEndHere = array[i];
                beginTemp = i;
            }
            if (maxEndHere > maxSoFar)
            {
                maxSoFar = maxEndHere;
                begin = beginTemp;
                end = i;
            }
        }

        Console.Write("The maximum sequel of numbers is {0} in length and is ", end - begin + 1);
        Console.Write("{");
        for (int i = begin; i <= end; i++)
        {
            Console.Write(array[i]);

            if (i == end)
            {
                Console.WriteLine("}");
                break;
            }
            Console.Write(", ");
        }
    }
}

