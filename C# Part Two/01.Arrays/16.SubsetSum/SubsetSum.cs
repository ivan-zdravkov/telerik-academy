// We are given an array of integers and a number S. 
// Write a program to find if there exists a subset of the elements of the array that has a sum S. 
// Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

using System;
using System.Collections.Generic;

class SubsetSum
{
    static void Main()
    {
        /*int sum = 0;
        while (sum < 1)
        {
            Console.Write("Enter the sum you are looking for: ");
            sum = int.Parse(Console.ReadLine());
        }
        int size = 0;
        while (size < 1)
        {
            Console.Write("Enter the size of the array: ");
            size = int.Parse(Console.ReadLine());
        }
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element {0} of the array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }*/

        int sum = 16;
        int[] array = { 1, 2, 3, 4, 5, 6 };

        Array.Sort(array, (x, y) => y.CompareTo(x)); // Decreasing sort
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();

        List<int> sumIndex = new List<int>();
        FindSum(array, 0, 0, sum, sumIndex);
        PrintList(sum, sumIndex);
    }

    private static void FindSum(int[] array, int startIndex, int currentSum, int targetSum, List<int> sumIndex)
    {
        for (int i = startIndex; i < array.Length; i++)
        {
            if ((currentSum + array[i]) < targetSum)
            {
                sumIndex.Add(array[i]);
                currentSum += array[i];
            }
            else if (currentSum + array[i] == targetSum)
            {
                sumIndex.Add(array[i]);
                return;
            }
        }
        if (currentSum < targetSum)
        {
            sumIndex.Clear();
        }
    }

    private static void PrintList(int sum, List<int> sumIndex)
    {
        Console.WriteLine();
        for (int i = 0; i < sumIndex.Count; i++)
        {
            Console.WriteLine("{0,11}", sumIndex[i]);
            if (i != (sumIndex.Count - 1))
            {
                Console.Write("{0}", new string(' ', 11));
                Console.WriteLine("+");
            }
        }
        if (sumIndex.Count > 0)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("{0,11}", sum);
        }
        else
        {
            Console.WriteLine("The sum {0} is larger than the sum of the elements in the array!", sum);
        }
    }
}

