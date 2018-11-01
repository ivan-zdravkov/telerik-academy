// You are given an array of strings. 
// Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class StringLengthSort
{
    static void Main()
    {
        int size = 0;
        while (size < 1)
        {
            Console.Write("Enter the size of the array: ");
            size = int.Parse(Console.ReadLine());
        }

        string[] words = new string[size];
        Console.WriteLine("Enter {0} strings", words.Length);
        for (int i = 0; i < words.Length; i++)
        {
            Console.Write("Enter [{0}]: ", i);
            words[i] = Console.ReadLine();
        }
        LengthSort(words);
        Print(words);
    }

    static void LengthSort(string[] wordList)
    {
        Array.Sort(wordList, (a, b) => a.Length.CompareTo(b.Length));
    }

    static void Print(string[] arrayToPrint)
    {
        Console.Write("{" + " ");
        for (int i = 0; i < arrayToPrint.Length; i++)
        {
            Console.Write(arrayToPrint[i]);
            if (i != arrayToPrint.Length - 1)
            {
                Console.Write(", ");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine("}");
    }
}

