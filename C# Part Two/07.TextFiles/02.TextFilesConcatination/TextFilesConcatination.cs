// Write a program that concatenates two text files into another text file
using System;
using System.IO;


class TextFilesConcatination
{
    static void Main()
    {
        try
        {
            StreamReader readFirst = new StreamReader("../../firstFile.txt");
            using (readFirst)
            {
                StreamReader readSecond = new StreamReader("../../secondFile.txt");
                using (readSecond)
                {
                    string first = readFirst.ReadToEnd();
                    string second = readSecond.ReadToEnd();
                    string unity = first + "\n" + second;

                    StreamWriter writeUnity = new StreamWriter("../../unityFile.txt", false);
                    using (writeUnity)
                    {
                        writeUnity.Write(unity);
                    }
                    StreamReader readUnity = new StreamReader("../../unityFile.txt");
                    Console.WriteLine(first + "\n");
                    Console.WriteLine(second + "\n");
                    Console.WriteLine(readUnity.ReadToEnd());
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
