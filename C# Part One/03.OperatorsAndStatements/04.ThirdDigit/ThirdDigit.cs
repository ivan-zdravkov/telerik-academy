// Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

class ThirdDigit
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        while ((integer >= -99) && (integer <= 99)) // the while loop will repeat itself untill the condition becomes false
        {
            Console.Write("Please enter an integer with atleast 3 digits: ");
            integer = int.Parse(Console.ReadLine());
        }
        bool isSeven = (Math.Abs((integer / 100) % 10) == 7);
        Console.WriteLine("The third digit of {0} is 7: {1}", integer, isSeven);

        //NOTE: If integer is negative, ((integer/100) % 10) will return a negative number. We use the Math.Abs() method to get a possitive result.
    }
}

