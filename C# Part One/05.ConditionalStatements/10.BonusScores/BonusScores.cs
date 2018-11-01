// Write a program that applies bonus scores to given scores in the range [1..9]. 
// The program reads a digit as an input. If the digit is between 1 and 3, 
// the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; 
// if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value is not a digit, the program must report an error.
// Use a switch statement and at the end print the calculated new value in the console.

using System;

class BonusScores
{
	static void Main()
	{
        int number = 0;
        bool valid = false;
        while ((valid != true) || ((number < 1) || (number > 9)))
        {
            Console.Write("Enter a number [1; 9]: ");
            valid = int.TryParse(Console.ReadLine(), out number);
            if (!valid)
            {
                Console.WriteLine("Please enter a valid number!\n");
            }
            else if (number == 0)
            {
                Console.WriteLine("ERROR, you have entered 0! Please enter a number in the interval [1; 9]\n"); //This is strange to report, but it's the task
            }
            else if ((number < 1) || (number > 9))
            {
                Console.WriteLine("The number has to be in the interval [1; 9]!\n");
            }
        }
        switch (number)
        {
            case 1:
            case 2:
            case 3:
                number *= 10;
                break;
            case 4:
            case 5:
            case 6:
                number *= 100;
                break;
            case 7:
            case 8:
            case 9:
                number *= 1000;
                break;
        }
        Console.WriteLine("The final score is {0}", number);
	}
}

