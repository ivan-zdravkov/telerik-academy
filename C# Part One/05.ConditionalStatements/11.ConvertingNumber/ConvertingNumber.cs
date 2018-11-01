//Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
//	0  "Zero"
//	273  "Two hundred seventy three"
//	400  "Four hundred"
//	501  "Five hundred and one"
//	711  "Seven hundred and eleven"

using System;


class ConvertingNumber
{
    static string Hundreths(int num) // Method that writes the hundreths
    {
        switch ((num / 100) % 10)
        {
            case 0: // If there are no hundreths it writes nothing
                return ""; // return, returns the value after it to the main program, and acts as a break
            case 1:
                if ((((num / 10) % 10) == 0) && ((num % 10) == 0)) // If the tenths and ones are both 0, it returns the hundreths without and
                {
                    return "one hundred";
                } 
                  // else it returns it with and. 
                  // NB: We don't have to include the next return in an else block, since if we enter the first if, we will exit the program, without reaching further!
                return "a hundred and ";
            case 2:
                if ((((num / 10) % 10) == 0) && ((num % 10) == 0))
                {
                    return "two hunderd";
                }
                return "two hunderd and ";
            case 3:
                if ((((num / 10) % 10) == 0) && ((num % 10) == 0))
                {
                    return "three hunderd";
                }
                return "three hundred and ";
            case 4:
                if ((((num / 10) % 10) == 0) && ((num % 10) == 0))
                {
                    return "four hunderd";
                }
                return "four hundred and ";
            case 5:
                if ((((num / 10) % 10) == 0) && ((num % 10) == 0))
                {
                    return "five hunderd";
                }
                return "five hundred and ";
            case 6:
                if ((((num / 10) % 10) == 0) && ((num % 10) == 0))
                {
                    return "six hunderd";
                }
                return "six hundred and ";
            case 7:
                if ((((num / 10) % 10) == 0) && ((num % 10) == 0))
                {
                    return "seven hunderd";
                }
                return "seven hundred and ";
            case 8:
                if ((((num / 10) % 10) == 0) && ((num % 10) == 0))
                {
                    return "eight hunderd";
                }
                return "eight hundred and ";
            case 9:
                if ((((num / 10) % 10) == 0) && ((num % 10) == 0))
                {
                    return "nine hunderd";
                }
                return "nine hundred and ";
            default:
                return "";
        }
    }

    static string Tenths(int num) // This method that prits the tenths!
    {
        if (((num / 10) % 10) == 0) // If there are none, it prits nothing
            return "";
        else if (((num / 10) % 10) == 1) // If the tenths == 1, it is a special case we look into
        {
            switch (num % 10)
            {
                case 0:
                    return "ten";
                case 1:
                    return "eleven";
                case 2:
                    return "twelve";
                case 3:
                    return "thirteen";
                case 4:
                    return "fourteen";
                case 5:
                    return "fifteen";
                case 6:
                    return "sixteen";
                case 7:
                    return "seventeen";
                case 8:
                    return "eighteen";
                case 9:
                    return "nineteen";
                default:
                    return "";
            }
        }
        else
        {
            switch ((num / 10) % 10)
            {
                case 2:
                    return "twenty ";
                case 3:
                    return "thirty ";
                case 4:
                    return "fourty ";
                case 5:
                    return "fifty ";
                case 6:
                    return "sixty ";
                case 7:
                    return "seventy ";
                case 8:
                    return "eighty  ";
                case 9:
                    return "ninety ";
                default:
                    return "";
            }
        }
    }

    static string Ones(int num) // This method that prints the ones
    {
        if ((num / 10) % 10 == 1) // If the tenths are in the special case == 1, we print nothing
            return "";
        else
        {
            switch (num % 10)
            {
                case 0:
                    return ""; 
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "";
            }
        }
    }

    static void Main()
    {
        int integer = -1;
        ConsoleKeyInfo exit;
        while (true)
        {
            integer = -1;
            while ((integer < 0) || (integer > 999))
            {
                Console.Write("Please enter a number [0, 999]: ");
                integer = int.Parse(Console.ReadLine());
            } 
            
            if (integer == 0)
            {
                Console.WriteLine("\nZero\n");
            }
            else
            {
                Console.WriteLine("\n{0}{1}{2}\n", Hundreths(integer), Tenths(integer), Ones(integer));
            }
            
            Console.Write("Press ENTER to enter a new number or any key to exit! ");
            exit = Console.ReadKey();
            if (exit.Key != ConsoleKey.Enter)
            {
                Console.WriteLine();
                break;
            }
            else
            {
                Console.Clear();
            }
        }
    }
}

