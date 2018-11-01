// Write a program that reads a date and time given in the format: 
// day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes 
// (in the same format) along with the day of week in Bulgarian.


using System;
using System.Globalization;
using System.Threading;

class HoursDifference
{
    static void Main()
    {
        bool repeat = true;
        while (repeat)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG");

            try
            {
                Console.WriteLine("Enter a date in the format Day.Month.Year hour:minute:second!\n");
                Console.Write("Enter the date:" );
                
                DateTime dateAndTime = GetTime();

                dateAndTime = dateAndTime.AddHours(6.5);

                Console.WriteLine("\nThe date and time after 6 hrs and 30 minutes will be {0}.{1}.{2} {3}:{4}:{5}", dateAndTime.Day, dateAndTime.Month, dateAndTime.Year, dateAndTime.Hour, dateAndTime.Minute, dateAndTime.Second);
                Console.WriteLine("This is {0}\n", dateAndTime.ToString("dddd", new CultureInfo("bg-BG")));
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

    static DateTime GetTime()
    {
        string[] date = Console.ReadLine().Split('.', ' ', ':');
        if (date.Length != 6)
        {
            throw new FormatException("Incorrect Day.Month.Year hour:minute:second input! Incorrect number of Parameters!");
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

        int hour = int.Parse(date[3]);
        if (hour < 0 || hour > 23)
        {
            throw new FormatException("The hour may only be [0, 23]!");
        }

        int minute = int.Parse(date[4]);
        if (minute < 0 || minute > 59)
        {
            throw new FormatException("The hour may only be [0, 59]!");
        }

        int second = int.Parse(date[5]);
        if (second < 0 || second > 24)
        {
            throw new FormatException("The hour may only be [0, 59]!");
        }

        return new DateTime(year, month, day, hour, minute, second);
    }
}