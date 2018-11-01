// Write an expression that checks if given integer is odd or even.

using System;

class IntEvenOrOdd
{
    static void Main()
    {
        Console.Write("Please enter an integer: ");
        int integer = int.Parse(Console.ReadLine());

        // Начин с тринарния оператор ? : и побитово 'И' на числото с 1-ца
        Console.WriteLine(((integer & 1) == 1) ? "The number is odd!" : "The number is even!");

        //Начин с if условна конструкция
        if (integer % 2 == 0)
            Console.WriteLine("The number is even!");
        else
            Console.WriteLine("The number is odd!");
    }
}
