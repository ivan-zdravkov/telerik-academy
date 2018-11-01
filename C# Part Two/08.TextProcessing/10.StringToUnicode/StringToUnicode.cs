// Write a program that converts a string to a sequence of C# Unicode character literals. 
// Use format strings. Sample input:


using System;
using System.Text;

class StringToUnicode
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string @string = Console.ReadLine();
        
        StringBuilder unicode = new StringBuilder(@string.Length * 6);

        foreach (char letter in @string)
        {
            unicode.AppendFormat("\\u{0:X4}", (int)letter);
        }

        Console.WriteLine(unicode.ToString());
    }
}