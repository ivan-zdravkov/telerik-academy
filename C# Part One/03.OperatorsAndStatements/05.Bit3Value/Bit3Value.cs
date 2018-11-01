//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class Bit3Value
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        int mask = 1;
        mask = mask << 3;
        mask &= integer;
        Console.WriteLine("The 3rd bit of the integer {0}, is {1}!", integer, mask == 0 ? "0" : "1");
        Console.WriteLine("{0}", Convert.ToString(integer, 2).PadLeft(32, '0'));
    }
}

