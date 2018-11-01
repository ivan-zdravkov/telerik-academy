// Write a program that deletes from a text file all words that start with the prefix "test". 
// Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;

class DeletingWords
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader("../../File.txt");
            using (reader)
            {
                StreamWriter writer = new StreamWriter("../../OutputFile.txt");
                using (writer)
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        writer.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
                    }
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