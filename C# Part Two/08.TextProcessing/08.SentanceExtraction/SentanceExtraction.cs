// Write a program that extracts from a given text all sentences containing given word.
// Example: The word is "in". The text is:
// Consider that the sentences are separated by "." and the words – by non-letter symbols

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class SentanceExtraction
{
    static string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
    static string key = "in";

    static void Main()
    {
        string[] sentances = text.Split('.');
        List<string> result = new List<string>();
        for (int i = 0; i < sentances.Length; i++)
        {
            if (Regex.Match(sentances[i], @"\b" + key + @"\b").Value != String.Empty)
            {
                result.Add(sentances[i].Trim());
            }
        }

        foreach (string sentance in result)
        {
            Console.WriteLine(sentance);
        }
    }
}