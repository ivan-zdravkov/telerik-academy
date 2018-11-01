// Write a program that reads from the console a string of maximum 20 characters. 
// If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
// Print the result string into the console.

using System;
using System.Text;

class StringMaxLength
{
    static void Main()
    {
        int sizeOfString = 20;
        string @string = String.Empty;

        while (@string == String.Empty || @string.Length > sizeOfString)
        {
            Console.Write("Enter a string ({0} characters MAX): ", sizeOfString);
            @string = Console.ReadLine();
        }

        StringBuilder fillingString = new StringBuilder(sizeOfString);
        for (int i = 0; i < sizeOfString; i++)
        {
            if (i < @string.Length)
            {
                fillingString.Append(@string[i]);
            }
            else
            {
                fillingString.Append('*');
            }
        }
        @string = fillingString.ToString();

        Console.WriteLine(@string);
    }
}