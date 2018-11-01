// Write a program that removes from a text file all words listed in given another text file. 
// Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _12.DeletingWordsMkII
{
    class DeletingWordsMkII
    {
        static void Main()
        {
            {
                try
                {
                    string regex = @"\b(" + String.Join("|", File.ReadAllLines("../../Words.txt")) + @")\b";

                    StreamReader reader = new StreamReader("../../File.txt");
                    using (reader)
                    {
                        StreamWriter writer = new StreamWriter("../../OutputFile.txt");
                        using (writer)
                        {
                            while (!reader.EndOfStream)
                            {
                                string line = reader.ReadLine();
                                writer.WriteLine(Regex.Replace(line, regex, String.Empty));
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
    }
}
