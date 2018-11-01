// * Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float). 
// Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.
using System;

class FloatingPointRepresentation
{
    static void Main()
    {
        Console.Write("Enter the floating point number: ");
        float number = float.Parse(Console.ReadLine());

        long convertedBitsOfNumber = BitConverter.DoubleToInt64Bits(number); // msdn.microsoft.com/en-us/library/system.bitconverter.aspx
        long mask = 1;
        long sign = 0;
        string binaryRepresentation = "";
        string exponent = "";
        string mantisa = "";

        sign = ((convertedBitsOfNumber >> 63) & mask);
        convertedBitsOfNumber = (convertedBitsOfNumber & (~(mask << 63))); // We are clearing the first bit of the converted number, so it will be possitive

        while (convertedBitsOfNumber != 0) // We are cicling through the bits
        {
            binaryRepresentation = (convertedBitsOfNumber % 2) + binaryRepresentation;
            convertedBitsOfNumber /= 2;
        } // At this point, we already have the bit representation of the number, all we need to do is split it and get just the bits we need

        if ((number > -2.0f) && (number < 2.0f))
        {
            exponent = "0";
            exponent += binaryRepresentation.Substring(3, 7);
            mantisa = binaryRepresentation.Substring(10, 23);
        }
        else
        {
            exponent = binaryRepresentation.Substring(0, 1);
            exponent += binaryRepresentation.Substring(4, 7);
            mantisa = binaryRepresentation.Substring(11, 23);
        }

        Console.Write("{0} {1} {2}\n", sign, exponent, mantisa);
    }
}

