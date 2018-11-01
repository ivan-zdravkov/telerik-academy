// Create a program that assigns null values to an integer and to double variables. 
// Try to print them on the console, try to add some values or the null literal to them and see the result.


using System;

class NullValue
{
    static void Main()
    {
        int? @int = null; // We use nullable int (int?) to assign a null to int.
        double? @double = null; // We use nullable double (double?) to assign a null to double.
        Console.WriteLine("{0}\n{1}", @int, @double); // null prints nothing!
        @int += 10;
        @double += 10.0;
        Console.WriteLine("{0}\n{1}", @int, @double); // null + integer/double is still null!
        @int = 10;
        @double = 10.0;
        Console.WriteLine("{0}\n{1}", @int, @double); // if we assign an integer/double to a nullable variable it now has a value!
    }
}

