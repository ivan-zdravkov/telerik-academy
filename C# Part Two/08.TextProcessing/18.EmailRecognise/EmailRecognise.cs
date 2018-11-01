// Write a program for extracting all email addresses from given text. 
// All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;

class EmailRecognise
{
    static void Main()
    {
        string @string = "Nakov@gmail.com is the email (maybe) of Svetlin Nakov, but Nakov@abv.bg may also be his email, or neither of theese is his email. I don't really know.";

        foreach (Match email in Regex.Matches(@string, @"[\w.]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}"))
        {
            Console.WriteLine(email);
        }
    }
}