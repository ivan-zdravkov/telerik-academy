// Write a program that reads two dates in the format: 
// day.month.year and calculates the number of days between them.


using System;

class DaysDifference
{
    static void Main()
    {
        bool repeat = true;
        while (repeat)
        {
            try
            {
                Console.WriteLine("Enter 2 dates in the format Day.Month.Year to calculate the day differences:\n");
                Console.Write("Enter the first date: ");
                DateTime dateOne = GetDate();
                Console.Write("Enter the second date: ");
                DateTime dateTwo = GetDate();

                int daysDifference = Math.Abs((dateOne - dateTwo).Days);
                Console.WriteLine("\nThere are {0} days between the two dates!", daysDifference);

            }
            catch (FormatException ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Would you like to restart the program?");
                Console.WriteLine("Press 'y' to restart!");
                Console.WriteLine("Press 'n' to exit!");
                string choice = string.Empty;
                while (choice != "y" && choice != "n" && choice != "Y" && choice != "N")
                {
                    Console.Write("Enter your choice: ");
                    choice = Console.ReadLine();
                }
                if (choice == "y" || choice == "Y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
                Console.WriteLine(new String('-', 40));
                Console.WriteLine();
            }
        }
    }

    static DateTime GetDate()
    {
        string[] date = Console.ReadLine().Split('.');
        if (date.Length != 3)
        {
            throw new FormatException("Incorrect Day.Month.Year input! Incorrect number of Parameters!");
        }

        int day = int.Parse(date[0]);
        if (day < 1 || day > 31)
        {
            throw new FormatException("The day may only be [1, 31]!");
        }

        int month = int.Parse(date[1]);
        if (month < 1 || month > 12)
        {
            throw new FormatException("The month may only be [1, 12]!");
        }

        int year = int.Parse(date[2]);
        if (year < 1 || year > 9999)
        {
            throw new FormatException("The year may only be [1, 9999]!");
        }

        return new DateTime(year, month, day);
    }
}