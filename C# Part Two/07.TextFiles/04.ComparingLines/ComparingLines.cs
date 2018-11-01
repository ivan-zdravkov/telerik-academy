// Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. 
// Assume the files have equal number of lines.

using System;
using System.IO;

class ComparingLines
{
    static void Main()
    {
        try
        {
            StreamReader fileOne = new StreamReader("../../FileOne.txt");
            using (fileOne)
            {
                StreamReader fileTwo = new StreamReader("../../FileTwo.txt");
                using (fileTwo)
                {
                    int sameLines = 0;
                    int differentLines = 0;
                    while (!fileOne.EndOfStream && !fileTwo.EndOfStream)
                    {
                        if (fileOne.ReadLine() == fileTwo.ReadLine())
                        {
                            sameLines++;
                        }
                        else
                        {
                            differentLines++;
                        }
                    }
                    Console.WriteLine("The number of same lines is {0}", sameLines);
                    Console.WriteLine("The number of different lines is {0}", differentLines);
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
