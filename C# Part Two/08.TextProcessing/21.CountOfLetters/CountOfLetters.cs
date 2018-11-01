// Write a program that reads a string from the console and prints all different letters in the string 
// along with information how many times each letter is found. 

using System;

class CountOfLetters
{
    static void Main()
    {
        Console.Write("Enter the string: ");
        string text = Console.ReadLine().ToLower();

        int[] letters = new int[26];
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] >= 'a' && text[i] <= 'z')
            {
                letters[text[i] - 'a']++;
            }
        }

        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] != 0)
            {
                Console.WriteLine("{0} - {1}",(char)('a' + i) ,letters[i]);
            }
        }

    }
}