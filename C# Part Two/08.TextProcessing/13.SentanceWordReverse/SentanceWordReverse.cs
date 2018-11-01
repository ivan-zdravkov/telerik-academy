// Write a program that reverses the words in given sentence.
// Example: "C# is not C++, not PHP and not Delphi!"
//          "Delphi not and PHP, not C++ not is C#!"
// 
// NB! My outbut gets a little different result than the example, but more accurate!!!

using System;
using System.Text;

class SentanceWordReverse
{
    static void Main()
    {
        string sentance = "C# is not C++, not PHP and not Delphi!";
        Console.WriteLine(sentance);
        Console.WriteLine(WordReverse(sentance));
    }

    static string WordReverse(string sentance)
    {
        char endOfSentance = sentance[sentance.Length - 1];
        sentance = sentance.Remove(sentance.Length - 1);
        
        string[] words = sentance.Split(' ');
        StringBuilder reverse = new StringBuilder();

        for (int i = words.Length - 1; i >= 0; i--)
        {
            if (words[i][words[i].Length - 1] != ',')
            {
                reverse.Append(words[i]);
            }
            else
            {
                string word = words[i].Remove(words[i].Length - 1);
                reverse.Append(",");
                reverse.Append(word);
            }

            if (i != 0)
            {
                reverse.Append(" ");
            }
        }
        reverse.Append(endOfSentance);

        return reverse.ToString();
    }
}