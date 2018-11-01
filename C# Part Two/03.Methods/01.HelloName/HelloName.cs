// Write a method that asks the user for his name and prints
// “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.

using System;

class HelloName
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string yourName = Console.ReadLine();
        GetName(yourName);
    }

    static void GetName(string name)
    {
        Console.WriteLine("\"Hello " + name + "\"");
    }
}

