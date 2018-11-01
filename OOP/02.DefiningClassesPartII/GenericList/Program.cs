/*
    5) Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, 
clearing the list, finding element by its value and ToString(). Check all input parameters to avoid accessing elements at invalid positions.
    6) Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
    7) Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. 
You may need to add a generic constraints for the type T.
*/

using System;

namespace GenericList
{
    class Program
    {
        static void Main()
        {
            GenericList<int> listOfNumbers = new GenericList<int>(4);
            listOfNumbers.Add(12);
            listOfNumbers.Add(-2);
            listOfNumbers.Add(4);
            listOfNumbers.Add(16);
            listOfNumbers.Add(8);
            listOfNumbers.Add(10);
            Console.WriteLine(listOfNumbers.ToString() + "\n");

            int? index = listOfNumbers.FindIndexOf(-2);
            Console.WriteLine("The index of <{0}> is {1}!", listOfNumbers[(int)index], index);
            index = listOfNumbers.FindIndexOf(10);
            Console.WriteLine("The index of <{0}> is {1}!\n", listOfNumbers[(int)index], index);

            listOfNumbers.InsertAt(9, 5);
            Console.WriteLine(listOfNumbers.ToString());

            index = listOfNumbers.FindIndexOf(10);
            Console.WriteLine("The index of <{0}> is {1}!\n", listOfNumbers[(int)index], index);

            int minimum = int.MaxValue;
            int maximum = int.MinValue;
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                minimum = GenericList<int>.Min(minimum, listOfNumbers[i]);
                maximum = GenericList<int>.Max(maximum, listOfNumbers[i]);
            }

            Console.WriteLine("The minimum number is {0}", minimum);
            Console.WriteLine("The maximum number is {0}", maximum);

        }
    }
}
