// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
using System;

class ShortBinaryRepresentation
{
    static void Main(string[] args)
    {
        Console.Write("Enter a short number: ");
        short number = short.Parse(Console.ReadLine());

        if (number >= 0)
        {
            string positiveNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            Console.WriteLine(positiveNumber);
        }
        else
        {
            string negativeNumber = Convert.ToString(-1 * (short.MinValue - number) - short.MinValue, 2).PadLeft(16, '0');
            Console.WriteLine(negativeNumber);
        }
    }
}
