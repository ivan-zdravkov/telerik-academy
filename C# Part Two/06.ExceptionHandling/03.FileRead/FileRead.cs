// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
// reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
// Be sure to catch all possible exceptions and print user-friendly error messages.

using System;

class FileRead
{
    static void Main()
    {
        while (true)
        {
            string filePath = @"C:\WINDOWS\win.ini";
            Console.Write("Enter the file path: ");
            filePath = Console.ReadLine();

            try
            {
                string content = System.IO.File.ReadAllText(filePath);
                Console.WriteLine(content);
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("The directory was not found! Please enter a new path!");
            }
            catch (System.IO.DriveNotFoundException)
            {
                Console.WriteLine("The drive was not found! Please enter a new path!");
            }
            catch (System.IO.FileLoadException)
            {
                Console.WriteLine("The file cannot be loaded!");
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("The file cannot be found!");
            }
            catch (System.IO.PathTooLongException)
            {
                Console.WriteLine("The path was too long!");
            }
            catch (Exception)
            {
                Console.WriteLine("Something unexpected has happened!");
            }
            finally
            {
                Console.WriteLine();
            }
        }
    }
}
