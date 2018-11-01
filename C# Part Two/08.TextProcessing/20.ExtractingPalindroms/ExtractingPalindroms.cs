// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;
using System.Text;

class ExtractingPalindroms
{
    static void Main()
    {
        string text = "Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.";
        string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder final = new StringBuilder();

        for (int i = 0; i < words.Length; i++)
        {
            bool isPalindrom = true;
            for (int j = 0; j < words[i].Length / 2; j++)
            {
                if (words[i][j] != words[i][words[i].Length - 1 - j])
                {
                    isPalindrom = false;
                }
            }
            if (isPalindrom == true && words[i].Length != 1)
            {
                final.AppendLine(words[i]);
            }
        }
        Console.Write(final.ToString());
    }
}
