// Write a program to read your age from the console and print how old you will be after 10 years.

using System;

class AgeReadConsole
{
    static void Main()
    {
        int age;
        Console.Write("Enter your age: ");
        age = int.Parse(Console.ReadLine());
        Console.WriteLine("In 10 years, your age will be {0}", age + 10);
    }
}