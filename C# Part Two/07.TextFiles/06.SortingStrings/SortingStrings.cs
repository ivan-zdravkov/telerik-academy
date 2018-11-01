// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 
// Example:
//	Ivan			George
//	Peter			Ivan
//	Maria			Maria
//	George			Peter
using System;
using System.Collections.Generic;
using System.IO;

class SortingStrings
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader("../../Input.txt");
            using (reader)
            {
                List<string> listOfNames = new List<string>();
                while (!reader.EndOfStream)
                {
                    listOfNames.Add(reader.ReadLine());
                }
                listOfNames.Sort();

                StreamWriter writer = new StreamWriter("../../Output.txt");
                using (writer)
                {
                    foreach (string name in listOfNames)
                    {
                        writer.WriteLine(name);
                    }
                }

                Console.WriteLine("DONE! Sorted list of names written to Output.txt.");
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