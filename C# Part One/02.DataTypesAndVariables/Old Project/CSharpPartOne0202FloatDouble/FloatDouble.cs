// Which of the following values can be assigned to a variable of type float and 
// which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

using System;

class FloatDouble
{
    static void Main()
    {
        float f1 = 12.345f;
        float f2 = 3456.091f;
        double d1 = 34.567839023;
        double d2 = 8923.1234857;
        Console.WriteLine("{0}\n{1}\n{2}\n{3}", f1, f2, d1, d2);
    }
}

