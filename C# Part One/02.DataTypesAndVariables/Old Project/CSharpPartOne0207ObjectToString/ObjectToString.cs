// Declare two string variables and assign them with “Hello” and “World”. 
// Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). 
// Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;

class ObjectToString
{
    static void Main()
    {
        string variable1 = "Hello";
        string variable2 = "World!";
        object container = variable1 + " " + variable2;
        string variable3 = (string)container;
        Console.WriteLine(variable3);
    }
}

