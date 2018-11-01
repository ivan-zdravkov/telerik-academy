// Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.

using System;

class BooleanIsFemale
{
    static void Main()
    {
        // A static solution!
        bool isFemale = false;
        Console.WriteLine("I am a female: {0}", isFemale); 

        // A solution which let's you choose whether you are a Male of Female 
        /*
        int gender = 0;
        label:
        Console.WriteLine("Are you a female ?\n1. Yes\n2. No");
        gender = int.Parse(Console.ReadLine());
        if(gender == 1)
            Console.WriteLine("You are a Female!");
        else if (gender == 2)
            Console.WriteLine("You are a Male!");
        else
        {
            Console.WriteLine("Please enter 1 for Female or 2 for Male only!");
            goto label;
        }
        */
    }
}
