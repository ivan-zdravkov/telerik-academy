// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
// Display them in the standard date format for Canada.


using System;
using System.Globalization;
using System.Text.RegularExpressions;

class DateExtraction
{
    static void Main()
    {
        string @string = "Today is 23.08.2013 I think this homework is due to 03.09.2013 so I have a lot of time ;)";

        DateTime date;
        foreach (Match item in Regex.Matches(@string, @"\b\d{2}.\d{2}.\d{4}\b"))
        {
            if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }
    }
}
