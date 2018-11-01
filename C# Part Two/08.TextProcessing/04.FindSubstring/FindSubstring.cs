// Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
// Example: The target substring is "in". The text is as follows:
// We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. 
// So we are drinking all the day. We will move out of it in 5 days.

using System;

class FindSubstring
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string subString = "in";

        int numberOfSubstrings = FindNumberOfSubstrings(text.ToLower(), subString);

        Console.WriteLine("The substring \"{0}\" can be found {2} times in the string:\n\"{1}\"", subString, text, numberOfSubstrings);
    }

    static int FindNumberOfSubstrings(string text, string subString)
    {
        int index = 0;
        int numberOfSubstrings = 0;

        while (index != -1)
        {
            index = text.IndexOf(subString, index + 1);
            numberOfSubstrings++;
        }

        return numberOfSubstrings - 1;
    }
}
