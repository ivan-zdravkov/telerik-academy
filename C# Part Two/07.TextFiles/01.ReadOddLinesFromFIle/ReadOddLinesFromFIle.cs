// Write a program that reads a text file and prints on the console its odd lines

using System;
using System.IO;
using System.Linq;


class ReadOddLinesFromFIle
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader("../../FileToRead.txt");
            using (reader)
            {
                bool tickTack = true;
                while (!reader.EndOfStream)
                {
                    if (tickTack)
                    {
                        Console.WriteLine(reader.ReadLine());
                        tickTack = false;
                    }
                    else
                    {
                        reader.ReadLine();
                        Console.WriteLine();
                        tickTack = true;
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
