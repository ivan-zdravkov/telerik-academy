// Write a program to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d).
// Example of incorrect expression: )(a+b)).

using System;
using System.Collections;

class CorrectBracketsCheck
{
    static void Main()
    {
        Console.Write("Enter an expression: ");
        string expression = Console.ReadLine();

        bool isCorrect = IsExpressionCorrect(expression);
        Console.WriteLine("The expression is {0}!", isCorrect ? "correct" : "incorrect");
    }

    static bool IsExpressionCorrect(string expression)
    {
        Stack bracketStack = new Stack();
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                bracketStack.Push('(');
            }
            else if (expression[i] == ')')
            {
                if (bracketStack.Count != 0)
                {
                    bracketStack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                continue;
            }
        }
        if (bracketStack.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
