// We are given a string containing a list of forbidden words and a text containing some of these words. 
// Write a program that replaces the forbidden words with asterisks.
// Words: "PHP, CLR, Microsoft"

using System;
using System.Text;

class ForbiddenWords
{
    static string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
    static string[] words = "PHP CLR Microsoft".Split(' ');
    
    static void Main()
    {
        StringBuilder fixxedText = new StringBuilder(text);

        foreach (string word in words)
        {
            fixxedText.Replace(word, new String('*', word.Length));
        }

        Console.WriteLine(fixxedText.ToString());
    }
}
