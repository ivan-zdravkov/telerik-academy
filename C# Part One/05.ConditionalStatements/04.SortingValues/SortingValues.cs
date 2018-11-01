//Sort 3 real values in descending order using nested if statements.

using System;

class SortingValues
{
    static void Main()
    {
        Console.Write("Number one: ");
        float numberOne = float.Parse(Console.ReadLine());
        Console.Write("Number two: ");
        float numberTwo = float.Parse(Console.ReadLine());
        Console.Write("Number three: ");
        float numberThree = float.Parse(Console.ReadLine());
        Console.WriteLine();

        float temp = 0; // I am using a temp variable for the code to be more readable. All the changes can be done with no extra variables!

        if (numberTwo > numberOne) // If (Two > One) ...
        {
            if (numberThree > numberTwo) // We first check if (Three > One) If so... 
            {
                temp = numberOne; // We exchage (One and Three)
                numberOne = numberThree;
                numberThree = temp;
            }
            else // If Three is not bigger than One - !(Three > One) 
            {
                temp = numberOne; // We exchange (One and Two)
                numberOne = numberTwo;
                numberTwo = temp;
                if (numberThree > numberTwo) // And then we check if (Three > Two), if so...
                {
                    temp = numberTwo; // We exchange (Two and Three)
                    numberTwo = numberThree;
                    numberThree = temp;
                }
            }
        }
        else if (numberThree > numberOne) // If Two is not bigger than One - !(Two > One) and Three is bigger than One - (Three > One)
        {
            temp = numberOne; // We exchage 1 and 3
            numberOne = numberThree;
            numberThree = temp;

            if (numberThree > numberTwo) // Then we check the new Three and Two. If (Three > Two)
            {
                temp = numberTwo; // We exchange (Three and Two)
                numberTwo = numberThree;
                numberThree = temp;
            }
        }
        else // If One is the biggest number
        {
            if (numberThree > numberTwo) // We check if (Three > Two). If so...
            {
                temp = numberTwo; // We exchange (Three and Two)
                numberTwo = numberThree;
                numberThree = temp;
            }
        }

        Console.WriteLine("{0}, {1}, {2}", numberOne, numberTwo, numberThree);
    }
}

