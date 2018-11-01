// Write a program that reads a list of words from a file words.txt and finds how many times each of the words is contained in another file test.txt. 
// The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order. 
// Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text.RegularExpressions;

class CountingWords
{
    static void Main()
    {
        try
        {
            string[] words = File.ReadAllLines("../../words.txt");
            int[] values = new int[words.Length];

            StreamReader reader = new StreamReader("../../input.txt");
            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    for (int i = 0; i < words.Length; i++)
                    {
                        values[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;
                    }
                }
            }

            Array.Sort(values, words);

            StreamWriter writer = new StreamWriter("../../output.txt");
            using (writer)
            {
                for (int i = words.Length - 1; i >= 0; i--)
                {
                    writer.WriteLine("{0}: {1}", words[i], values[i]);
                }
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
