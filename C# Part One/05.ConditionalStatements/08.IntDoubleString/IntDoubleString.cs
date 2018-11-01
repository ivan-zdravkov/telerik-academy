// Write a program that, depending on the user's choice inputs int, double or string variable. 
// If the variable is integer or double, increases it with 1. 
// If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.

using System;

class IntDoubleString
{
	static void Main()
	{
        object @object = 0;
        byte choice;
        do
        {
            Console.WriteLine("0. Enter int ");
            Console.WriteLine("1. Enter double ");
            Console.WriteLine("2. Enter string ");
            Console.Write("Enter the type of your variable: ");
            choice = byte.Parse(Console.ReadLine());
            Console.WriteLine();
        } while (choice > 2);
        Console.Write("Enter the variable: ");
        switch (choice)
        {
            case 0:
                @object = int.Parse(Console.ReadLine()) + 1;
                break;
            case 1:
                @object = double.Parse(Console.ReadLine()) + 1;
                break;
            case 2:
                @object = Console.ReadLine() + "*";
                break;
            default:
                Console.WriteLine("ERROR");
                break;
        }
        Console.WriteLine("The variable's type is {0} and it's new value is: {1}\n", @object.GetType(), @object);
	}
}

