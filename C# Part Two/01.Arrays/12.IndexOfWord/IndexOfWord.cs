// Write a program that creates an array containing all letters from the alphabet (A-Z). 
// Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfWord
{
    static void Main()
    {
        char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        Console.Write("Please enter a single word (A - Z), (a - z): ");
        string word = Console.ReadLine();

        word = word.ToUpper(); // Upper chars only
        int stringLength = word.Length; // Getting the length 
        char[] charWord = new char[stringLength]; // Creating a char array
        int[] indexWord = new int[stringLength]; // Creating an integer array, that holds the index of the respective letter

        charWord = word.ToCharArray(); // Filling the char array

        bool error = false; // A flag, that becomes 'true' if the searched 'char' is not from the alphabet array

        for (int i = 0; i < stringLength; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (charWord[i] == alphabet[j])
                {
                    indexWord[i] = j;
                    break;
                }
                else
                {
                    if (j == alphabet.Length - 1)
                    {
                        error = true;
                    }
                }
            }
        }

        if (error == true)
        {
            Console.WriteLine("Some of the characters in the word are not valid!");
        }
        else
        {
            for (int i = 0; i < stringLength; i++)
            {
                Console.WriteLine("{0} -> {1}", charWord[i], indexWord[i]);
            }
        }
    }
}

