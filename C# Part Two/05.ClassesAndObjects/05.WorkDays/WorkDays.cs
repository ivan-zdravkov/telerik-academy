// Write a method that calculates the number of workdays between today and given date, passed as parameter. 
// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
using System;

class WorkDays
{
    static void Main()
    {
        int workingDays = -1;
        int year = DateTime.Now.Year - 1;
        int month = DateTime.Now.Month - 1;
        int day = DateTime.Now.Day - 1;

        DateTime dateInFuture = new DateTime(year, month, day);

        Console.WriteLine("Calculating how many working days there are from this moment to a future moment!");
        while (dateInFuture < DateTime.Now || workingDays < 0)
        {
            Console.WriteLine("\nEnter a Date in the FUTURE!");
            do
            {
                Console.Write("Enter Day: ");
                day = int.Parse(Console.ReadLine());
            } while (day < 1 || day > 31);
            do
            {
                Console.Write("Enter Month: ");
                month = int.Parse(Console.ReadLine());
            } while (month < 1 || month > 12);
            do
            {
                Console.Write("Enter Year: ");
                year = int.Parse(Console.ReadLine());
            } while (year < 1 || year > 9999);
            
            dateInFuture = new DateTime(year, month, day);
            workingDays = CalculateWorkDaysUntil(dateInFuture);

            if (workingDays > 0)
            {
                Console.WriteLine("The number of work days from {0} to {1} is {2}", DateTime.Now.ToShortDateString(), dateInFuture.ToShortDateString(), workingDays);
            }
        }
    }

    public struct Date
    {
        public int day;
        public int month;
    }

    static Date[] publicHolidays = new Date[12];

    static void InitializePublicHolidays()
    {
        publicHolidays[0].day = 1;
        publicHolidays[0].month = 1;
        publicHolidays[1].day = 2;
        publicHolidays[1].month = 1;
        publicHolidays[2].day = 3;
        publicHolidays[2].month = 3;
        publicHolidays[3].day = 1;
        publicHolidays[3].month = 5;
        publicHolidays[4].day = 6;
        publicHolidays[4].month = 5;
        publicHolidays[5].day = 24;
        publicHolidays[5].month = 5;
        publicHolidays[6].day = 6;
        publicHolidays[6].month = 9;
        publicHolidays[7].day = 22;
        publicHolidays[7].month = 9;
        publicHolidays[8].day = 1;
        publicHolidays[8].month = 11;
        publicHolidays[9].day = 24;
        publicHolidays[0].month = 12;
        publicHolidays[10].day = 25;
        publicHolidays[10].month = 12;
        publicHolidays[11].day = 26;
        publicHolidays[11].month = 12;
    }

    static int CalculateWorkDaysUntil(DateTime timeInTheFuture)
    {
        int numberOfWorkDays = 0;
        DateTime currentTime = DateTime.Now;
        if (timeInTheFuture < currentTime)
        {
            return -1;
        }
        else
        {
            while (currentTime < timeInTheFuture)
            {
                if ((int)currentTime.DayOfWeek == 0 || (int)currentTime.DayOfWeek == 6) // Sunday and Saturday
                {
                    currentTime = currentTime.AddDays(1);
                    continue;
                }
                foreach (Date date in publicHolidays)
                {
                    if (date.month == currentTime.Month && date.day == currentTime.Day)
                    {
                        currentTime = currentTime.AddDays(1);
                        continue;
                    }
                }
                numberOfWorkDays++;
                currentTime = currentTime.AddDays(1);
            }
            return numberOfWorkDays;
        }
    }
}
