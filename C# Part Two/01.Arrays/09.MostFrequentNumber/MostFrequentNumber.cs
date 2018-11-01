using System;
using System.Collections.Generic;

class MostFrequentNumber
{
    public struct numbers // A struct that saves a number and how many times it is in the array
    {
        public int value;
        public int timesInArray;
    }

    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        List<numbers> list = new List<numbers>(); // A list of the struct numbers. For every element of the list, we get value and how many times it is in the array

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element {0} of the array: ", i);
            array[i] = int.Parse(Console.ReadLine());
            if (i == 0) // If this is the first element of the array, we add the number in the list
            {
                numbers number = new numbers(); // We create a number from the struct numbers
                number.value = array[i]; // It's value
                number.timesInArray = 1; // How many times it is in the array (Since it's the first element, this is 1)
                list.Add(number); // We add this number in the list
            }
            else // If this is not the first element of the array
            {
                for (int j = 0; j < list.Count; j++) // We walk through all the elements 
                {
                    if (list[j].value == array[i]) // If we find the same number in it
                    {
                        numbers number = new numbers();
                        number.value = array[i];
                        number.timesInArray = list[j].timesInArray + 1; // We increase it's frequency in the array by 1
                        list[j] = number;
                        break;
                    }
                    if (j == list.Count - 1) // If we are at the last number of the list, and we have no match, we add the new number to the list!
                    {
                        numbers number = new numbers(); 
                        number.value = array[i];
                        number.timesInArray = 1;
                        list.Add(number);
                        break;
                    }
                }
            }
        }

        for (int i = 0; i < list.Count; i++) // Printing the list
        {
            Console.WriteLine("{0, -8} -> {1, -3} times", list[i].value, list[i].timesInArray);
        }

        int maxIndex = 0;
        int frequency = 0;
        
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].timesInArray > frequency)
            {
                frequency = list[i].timesInArray;
                maxIndex = i; // Getting the index that holds the most frequently used number!
            }
        }

        Console.WriteLine("The most frequent number in the array is the number {0}, that is in it {1} times!", list[maxIndex].value, list[maxIndex].timesInArray);
    }
}

