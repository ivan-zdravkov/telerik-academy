// Modify the solution of the previous problem to replace only whole words (not substrings)
//      Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
//      Ensure it will work with large files (e.g. 100 MB).
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class WordsReplacement
{
    static void Main()
    {
        try
        {
            bool backUp = false;
            backUp = CreateFileBackUp("../../File.txt");

            StringBuilder text = new StringBuilder();
            StreamReader reader = new StreamReader("../../File.txt");
            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine().Replace(" start ", " finish ");
                    string patern = @"\bstart\b";
                    string replace = "finish";
                    line = Regex.Replace(line, patern, replace);
                    text.Append(line + System.Environment.NewLine);
                }
            }
            StreamWriter writer = new StreamWriter("../../File.txt", false);
            using (writer)
            {
                writer.Write(text.ToString());
            }

            if (backUp)
            {
                Console.WriteLine("DONE! BackUp Created! File Changed!");
            }
            else
            {
                Console.WriteLine("DONE! File Changed!");
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

    public static bool CreateFileBackUp(string path)
    {
        string backUpPath = "../../" + "File" + ConvertToUnixTimestamp(DateTime.Now) + ".txt";

        StreamReader reader = new StreamReader(path);
        using (reader)
        {
            StreamWriter writer = new StreamWriter(backUpPath);
            using (writer)
            {
                while (!reader.EndOfStream)
                {
                    string line = "";
                    line = reader.ReadLine();
                    writer.WriteLine(line);
                }
            }
        }
        return true;
    }

    public static double ConvertToUnixTimestamp(DateTime date)
    {
        DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
        TimeSpan difference = date.ToUniversalTime() - origin;
        return Math.Floor(difference.TotalSeconds);
    }
}