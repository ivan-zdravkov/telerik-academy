// Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class ValuesExchange
{
    static void Main()
    {
        int integerOne = -5;
        int integerTwo = 15;
        Console.WriteLine("integerOne = {0}", integerOne);
        Console.WriteLine("integerOne = {0}", integerTwo);
        // Solution with an extra variable
        /*
        int swapInteger; 
        swapInteger = integerOne;
        integerOne = integerTwo;
        integerTwo = swapInteger;
        */
        // A more elegant solution with no extra variable
        integerOne += integerTwo; 
        integerTwo = integerOne - integerTwo;
        integerOne -= integerTwo;
        Console.WriteLine("integerOne = {0}", integerOne);
        Console.WriteLine("integerOne = {0}", integerTwo);
    }
}

