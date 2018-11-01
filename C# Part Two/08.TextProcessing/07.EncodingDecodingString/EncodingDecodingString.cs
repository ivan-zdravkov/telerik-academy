// Write a program that encodes and decodes a string using given encryption key (cipher). 
// The key consists of a sequence of characters. 
// The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string 
// with the first of the key, the second – with the second, etc. 
// When the last key character is reached, the next is the first.


using System;
using System.Text;

class EncodingDecodingString
{
    static char[] cipher = "The Doctor".ToCharArray();

    static void Main()
    {
        Console.Write("Enter a string to encode / decode: ");
        string @string = Console.ReadLine();
        @string = EncodeDecode(@string, cipher);
        Console.WriteLine("The encoded string is: " + @string);
        @string = EncodeDecode(@string, cipher);
        Console.WriteLine("The decoded string is: " + @string);
    }

    static string EncodeDecode(string @string, char[] cipher)
    {
        int cipherIndex = 0;
        StringBuilder encodedString = new StringBuilder(@string.Length);
        for (int i = 0; i < @string.Length; i++)
        {
            encodedString.Append((char)(@string[i] ^ cipher[cipherIndex]));
            if (cipherIndex < cipher.Length - 1)
            {
                cipherIndex++;
            }
            else
            {
                cipherIndex = 0;
            }
        }
        return encodedString.ToString();
    }
}
