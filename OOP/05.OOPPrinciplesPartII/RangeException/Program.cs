using System;
using System.Collections.Generic;

namespace RangeException
{
    class Program
    {
        static void Main()
        {
            int number = 200;
            int intStart = 1;
            int intEnd = 100;

            try
            {
                if (number < intStart || number > intEnd)
                {
                    string errorMessage = String.Format("The int {2} was outside the range [{0} - {1}]", intStart, intEnd, number);
                    throw new InvalidRangeException<int>(errorMessage, intStart, intEnd);
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Start: {0}", ex.MinRange);
                Console.WriteLine("End: {0}", ex.MaxRange);
            }

            Console.WriteLine(new String('=', 80));

            DateTime start = new DateTime(1980, 1, 1);
            DateTime end = new DateTime(2013, 12, 31);

            Console.WriteLine("Use the following format: YYYY.MM.DD");
            Console.WriteLine("Enter a birth date in the range [{0}.{1}.{2} - {3}.{4}.{5}]", start.Year, start.Month, start.Day, end.Year, end.Month, end.Day);
            List<DateTime> dates= new List<DateTime>();
            
            while (true)
            {
                try
                    {
                    Console.Write("\nEnter a date: ");
                    string input = Console.ReadLine();
                    string[] inputDate = input.Split('.');

                    int year = int.Parse(inputDate[0]);
                    if (year < 1 || year > 9999)
                    {
                        throw new ArgumentException("The year must be [1 - 9999]");
                    }

                    int month = int.Parse(inputDate[1]);
                    if (month < 1 || month > 12)
                    {
                        throw new ArgumentException("The month must be [1 - 12]");
                    }

                    int day = int.Parse(inputDate[2]);
                    if (day < 1 || day > 31)
                    {
                        throw new ArgumentException("The day must be [1 - 31]");
                    }

                    DateTime date = new DateTime(year, month, day);

                    if (date < start || date > end)
                    {
                        string errorMessage = String.Format("The date you entered was outside the range [{0}.{1}.{2} - {3}.{4}.{5}]", start.Year, start.Month, start.Day, end.Year, end.Month, end.Day);
                        throw new InvalidRangeException<DateTime>(errorMessage, start, end);
                    }
                    else
                    {
                        dates.Add(date);
                    }

                    Console.WriteLine("{0}.{1}.{2} - OK (Added to list!)\n", date.Year, date.Month, date.Day);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.Write("{0}", ex.GetType().Name);
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidRangeException<DateTime> ex)
                {
                    Console.Write("{0}\n", ex.GetType().Name);
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
