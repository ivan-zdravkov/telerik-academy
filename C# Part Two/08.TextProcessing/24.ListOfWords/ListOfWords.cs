// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ListOfWords
{
    static void Main()
    {
        string @string = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.";

        List<string> words = new List<string>();

        foreach (Match word in Regex.Matches(@string, @"\w+"))
        {
            words.Add(word.Value);
        }

        words.Sort();

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}
