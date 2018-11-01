// Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

using System;

class BiggerExchange
{
	static void Main()
	{
        Console.Write("Enter the first integer: ");
        int bigger = int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer: ");
        int smaller = int.Parse(Console.ReadLine());
        if (smaller > bigger)
        {
            // Value exchange algorithm!
            bigger += smaller; 
            smaller = bigger - smaller;
            bigger -= smaller;
        }
        Console.WriteLine("\nThe bigger integer is: {0}\n", bigger);
	}
}

