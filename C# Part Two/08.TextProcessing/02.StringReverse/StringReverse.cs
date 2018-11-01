// Write a program that reads a string, reverses it and prints the result at the console.
// Example: "sample"  "elpmas".


using System;
using System.Text;

class StringReverse
{
    static void Main()
    {
        Console.Write("Enter a string:  ");
        string @string = Console.ReadLine();

        Console.WriteLine("Reversed string: " + ReverseString(@string));
    }

    private static string ReverseString(string @string)
    {
        char[] charArray = @string.ToCharArray();

        StringBuilder reversedString = new StringBuilder();
        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            reversedString.Append(charArray[i]);
        }

        return reversedString.ToString();
    }
}
