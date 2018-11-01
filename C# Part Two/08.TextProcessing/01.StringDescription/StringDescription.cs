// Describe the strings in C#. What is typical for the string data type? 
// Describe the most important methods of the String class.

using System;

class StringDescription
{
    static void Main()
    {
        string test = "This is a test of the string methods!";
        test.CompareTo("Test"); // Compares the two strings by their lexicographical ordering
        test.Contains("is"); // Checks if a substring is in the string
        test.Equals("Test"); // Checks if the two strings have the same value
        int index = 0;
        test.IndexOf("is", index); // returns the possition of the first occurance of the substring after possition index;
        int lengthOfString = test.Length; // The length of the string
        test.Replace("is", "isn't"); // Replaces a substring with another substring
        test.Split(' '); // Splits the string into string[] containing all the "words" that the separator forms
        test.Substring(5, lengthOfString - 8); // Returns a substring from possition (5) with length of substring (lengthOfString - 8)
        test.ToCharArray(); // Returns a char[]
        test.ToLower(); // Lowers the capital letters
        test.ToUpper(); // Capitalises the lower letters
        test.Trim(); // Removes the whitespace
    }
}
