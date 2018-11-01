// Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CharArrayComparisson
{
	static void Main()
	{
        int size = 0;
        while (size < 1)
        {
            Console.Write("Enter the size of the char arrays: ");
            size = int.Parse(Console.ReadLine());
        }
        char[] arrayOne = new char[size];
        char[] arrayTwo = new char[size];

        for (int i = 0; i < arrayOne.Length; i++)
        {
            Console.Write("Enter arrayOne[{0}] = ", i);
            arrayOne[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        for (int i = 0; i < arrayTwo.Length; i++)
        {
            Console.Write("Enter arrayTwo[{0}] = ", i);
            arrayTwo[i] = char.Parse(Console.ReadLine()); 
        }
        int bigger = 0; // 1 - arrayOne bigger, 2 - arrayTwo bigger
        for (int i = 0; i < arrayOne.Length; i++)
        {
            Console.Write(arrayOne[i]);
            if (arrayTwo[i] == arrayOne[i])
            {
                Console.Write(" = ");
            }
            else
            {
                if (arrayOne[i] > arrayTwo[i])
                {
                    Console.Write(" > ");
                    if (bigger == 0)
                    {
                        bigger = 1;
                    }
                }
                else
                {
                    Console.Write(" < ");
                    if (bigger == 0)
                    {
                        bigger = 2;
                    }
                }
            }
            Console.WriteLine(arrayTwo[i]);
        }
        if (bigger == 0)
        {
            Console.WriteLine("The two char arrays are equal!");
        }
        else if (bigger == 1)
        {
            Console.WriteLine("The first char array is lexicographically bigger!");
        }
        else if (bigger == 2)
        {
            Console.WriteLine("The second char array is lexicographically bigger!");
        }
	}
}

