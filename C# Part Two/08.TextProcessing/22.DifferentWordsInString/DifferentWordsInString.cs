// Write a program that reads a string from the console and lists all different words in the string 
// along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class DifferentWordsInString
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../twinkle.txt");
        using (reader)
        {
            string text = reader.ReadToEnd();
            var dictionary = new Dictionary<string, int>();

            foreach (Match word in Regex.Matches(text, @"\w+"))
            {
                if (!dictionary.ContainsKey(word.Value))
                {
                    dictionary[word.Value] = 1;
                }
                else
                {
                    dictionary[word.Value] += 1;
                }
            }

            foreach (var word in dictionary)
            {
                Console.WriteLine("{0,15} - {1}", word.Key, word.Value);
            }
        }
    }
}
