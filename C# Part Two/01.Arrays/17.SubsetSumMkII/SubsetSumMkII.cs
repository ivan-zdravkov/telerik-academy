// * Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
// Find in the array a subset of K elements that have sum S or indicate about its absence.
using System;
using System.Collections.Generic;

class SubsetSumMkII
{
    static void Main()
    {
        int sum = 0; // S
        while (sum < 1)
        {
            Console.Write("Enter the sum you are looking for: ");
            sum = int.Parse(Console.ReadLine());
        }
        int sizeOfSubset = 0; // K
        while (sizeOfSubset < 1)
        {
            Console.Write("Enter the size of the subset: ");
            sizeOfSubset = int.Parse(Console.ReadLine());
        }
        int size = 0; // N
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
        }

        Array.Sort(array, (x, y) => y.CompareTo(x)); // Decreasing sort
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();

        List<int> sumIndex = new List<int>();
        FindSum(array, 0, 0, sum, sumIndex);
        if (sizeOfSubset == sumIndex.Count)
        {
            PrintList(sum, sumIndex);
        }
        else
        {
            Console.WriteLine("There are no {0} elements in the array, which sum adds up to {1}", sizeOfSubset, sum);
        }
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

