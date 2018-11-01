// Write a program that reads a text file and inserts line numbers in front of each of its lines. 
// The result should be written to another text file.
using System;
using System.IO;

class TextFileLining
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader("../../FileToRead.txt");
            using (reader)
            {
                string resultString = string.Empty;
                for (int i = 0; !reader.EndOfStream; i++)
                {
                    resultString += "Line " + (i + 1) + ": " + reader.ReadLine() + "\r\n";
                }
                StreamWriter writer = new StreamWriter("../../ResultFile.txt", false);
                using (writer)
                {
                    writer.Write(resultString);
                    Console.WriteLine(resultString);
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
