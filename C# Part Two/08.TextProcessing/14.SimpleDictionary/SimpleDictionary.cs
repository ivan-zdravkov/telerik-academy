// A dictionary is stored as a sequence of text lines containing words and their explanations. 
// Write a program that enters a word and translates it by using the dictionary.

using System;

class SimpleDictionary
{
    static void Main()
    {
        string[] dictionary = {
                                     ".NET – platform for applications from Microsoft",
                                     "CLR – managed execution environment for .NET",
                                     "namespace – hierarchical organization of classes"
                                 };

        while (true)
        {
            Console.Write("Enter a word to translate: ");
            string word = Console.ReadLine();
            Console.WriteLine("{0} -> {1}", word, Translate(word, dictionary));
            Console.WriteLine();
        }
    }

    static string Translate(string word, string[] dictionary)
    {
        string match = string.Empty;
        for (int i = 0; i < dictionary.Length; i++)
        {
            if (dictionary[i].IndexOf(word.ToUpper()) == 0 || dictionary[i].IndexOf(word.ToLower()) == 0)
            {
                match = dictionary[i];
            }
        }
        if (match != string.Empty)
        {
            int charsToRemove = word.Length + 3;
            return match.Substring(charsToRemove, match.Length - charsToRemove);
        }
        else
        {
            return "The word you are looking for is not in the dictionary!";
        }
        
    }
}
