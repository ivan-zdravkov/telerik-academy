// Write a boolean expression that checks for given integer if it 
// can be divided (without remainder) by 7 and 5 in the same time.

using System;

class BooleanDevision
{
    static void Main()
    {
        Console.Write("Please enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        bool devCheck = ((integer % 5 == 0) && (integer % 7 == 0));
        Console.WriteLine("The integer {0}, {1} be devided by 5 and 7",
            integer, devCheck ? "can" : "cannot");
    }
}

