// * Write a program that calculates the value of given arithmetical expression. The expression can contain the following elements only:
// Real numbers, e.g. 5, 18.33, 3.14159, 12.6
// Arithmetic operators: +, -, *, / (standard priorities)
// Mathematical functions: ln(x), sqrt(x), pow(x,y)
// Brackets (for changing the default priorities)
// Examples:
// (3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7) ---> ~ 10.6
// pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3) ---> ~ 21.22
// Hint: Use the classical "shunting yard" algorithm and "reverse Polish notation".

// Credit to http://forums.academy.telerik.com/user/%D0%9C%D0%B0%D1%80%D1%82%D0%B8%D0%BD+%D0%9D%D0%B8%D0%BA%D0%BE%D0%BB%D0%BE%D0%B2 
// from the Telerik Academy. A few videos and a few ideas from him, helped me solve this task!
using System;
using System.Collections.Generic;

class ShuntingYardAlgorithm
{
    static List<char> operators = new List<char>() { '+', '-', '*', '/' };
    static List<char> functions = new List<char>() { 'p', '^', 's', 'l', 'n', 'c', 't' };

    static void Main()
    {
        Console.Write("Enter the expression: ");
        string expression = Console.ReadLine();
        Console.WriteLine(ConvertToTokens(expression));
        Console.WriteLine(Calculate(ConvertToTokens(expression)));
    }

    static string ConvertToTokens(string expression)
    {
        Stack<char> stack = new Stack<char>();
        string result = "";

        expression = SimplifyFunctionNames(expression);

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == ' ') continue;

            if (char.IsDigit(expression[i]) || (expression[i] == '-' && char.IsDigit(expression[i + 1])))
            {
                if (char.IsDigit(expression[i + 1]) || expression[i + 1] == '.' || expression[i + 1] == ' ')
                {
                    while (i < expression.Length && expression[i] != ' ' && (char.IsDigit(expression[i]) || expression[i] == '.' || expression[i] == '-'))
                    {
                        result += expression[i++];
                    }
                    i--;
                }
                else
                {
                    result += expression[i];
                }

                if (!char.IsDigit(expression[i]))
                {
                    result = result + expression[i] + ' ';
                }
                else
                {
                    result += ' ';
                }
            }
            else if (operators.Contains(expression[i]) || functions.Contains(expression[i]))
            {
                if (stack.Count > 0)
                {
                    int operatorOne = OperatorPriority(expression[i]);
                    int operatorTwo = OperatorPriority(stack.Peek());

                    if (operatorOne > operatorTwo)
                    {
                        stack.Push(expression[i]);
                    }
                    else
                    {
                        while (operatorOne <= operatorTwo && stack.Count > 0)
                        {
                            result = result + stack.Peek() + ' ';
                            stack.Pop();

                            if (stack.Count > 0)
                            {
                                operatorOne = OperatorPriority(expression[i]);
                                operatorTwo = OperatorPriority(stack.Peek());
                            }
                        }

                        stack.Push(expression[i]);
                    }
                }
                else
                {
                    stack.Push(expression[i]);
                }
            }
            else if (expression[i] == '(')
            {
                stack.Push(expression[i]);
            }
            else if (expression[i] == ')' || expression[i] == ',')
            {
                bool comma = (expression[i] == ',');

                while (stack.Peek() != '(' && stack.Count > 0)
                {
                    result = result + stack.Peek() + ' ';
                    stack.Pop();

                    if (stack.Count == 0)
                    {
                        Console.WriteLine("Incorrect expression!");
                        return string.Empty;
                    }
                }

                if (!comma)
                {
                    stack.Pop();
                }

                if (stack.Count > 0 && !comma && (stack.Peek() == 'p' || stack.Peek() == 's' || stack.Peek() == 'l'))
                {
                    result = result + stack.Pop() + " ";
                }
            }
        }

        while (stack.Count > 0)
        {
            if (stack.Peek() == '(')
            {
                Console.WriteLine("Incorrect expression!");
                return string.Empty;
            }

            result = result + ' ' + stack.Peek();
            stack.Pop();
        }

        return result.Replace("  ", " ");
    }

    static string Calculate(string tokenExpression)
    {
        Stack<double> result = new Stack<double>();
        string con = string.Empty;
        for (int i = 0; i < tokenExpression.Length; i++)
        {
            if (char.IsDigit(tokenExpression[i]) || (i + 1 < tokenExpression.Length && tokenExpression[i] == '-' && char.IsDigit(tokenExpression[i + 1])))
            {
                while (i < tokenExpression.Length && tokenExpression[i] != ' ' && (char.IsDigit(tokenExpression[i]) || tokenExpression[i] != '.' || tokenExpression[i] != '-'))
                {
                    i++;
                    con += tokenExpression[i - 1];
                }
                i--;
            }
            else
            {
                if (tokenExpression[i] == ' ')
                {
                    if (con.Length > 0)
                    {
                        double currentResult = 0;
                        if (!double.TryParse(con, out currentResult))
                        {
                            return "Incorrect expression!";
                        }
                        result.Push(currentResult);
                    }
                    con = string.Empty;
                }
                else
                {
                    if (result.Count >= 1)
                    {
                        double valueOne = 0;
                        double valueTwo = result.Pop();

                        if (!"slnct".Contains(tokenExpression[i].ToString()) && result.Count > 0)
                        {
                            valueOne = result.Pop();
                        }

                        if (tokenExpression[i] == '+')
                        {
                            result.Push(valueOne + valueTwo); // x + y
                        }
                        else if (tokenExpression[i] == '-')
                        {
                            result.Push(valueOne - valueTwo); // x - y
                        }
                        else if (tokenExpression[i] == '*')
                        {
                            result.Push(valueOne * valueTwo); // x * y
                        }
                        else if (tokenExpression[i] == '/')
                        {
                            result.Push(valueOne / valueTwo); // x / y
                        }
                        else if (tokenExpression[i] == '^' || tokenExpression[i] == 'p')
                        {
                            result.Push(Math.Pow(valueOne, valueTwo)); // pow(x, y) or x ^ y
                        }
                        else if (tokenExpression[i] == 's')
                        {
                            result.Push(Math.Sqrt(valueTwo)); // Sqrt(x)
                        }
                        else if (tokenExpression[i] == 'l')
                        {
                            result.Push(Math.Log(valueTwo, Math.E)); // ln(x)
                        }
                        else if (tokenExpression[i] == 'n')
                        {
                            result.Push(Math.Sin(valueTwo)); // Sin(x)
                        }
                        else if (tokenExpression[i] == 'c')
                        {
                            result.Push(Math.Cos(valueTwo)); // Cos(x)
                        }
                        else if (tokenExpression[i] == 't')
                        {
                            result.Push(Math.Tan(valueTwo)); // Tg(x)
                        }
                        else
                        {
                            result.Push(valueOne);
                            result.Push(valueTwo);
                        }
                    }
                }
            }
        }
        if (result.Count > 1)
        {
            return "Incorrect expression!";
        }
        else
        {
            return result.Peek().ToString();
        }
    }

    static string SimplifyFunctionNames(string expression) // Making function names chars!
    {
        string simpleExpression = "";
        for (int i = 0; i < expression.Length; i++)
        {
            if (char.IsUpper(expression[i]))
            {
                simpleExpression += char.ToLower(expression[i]);
            }
            else
            {
                simpleExpression += expression[i];
            }
        }

        simpleExpression += " ";

        simpleExpression = simpleExpression.Replace("pow", "p");
        simpleExpression = simpleExpression.Replace("sqrt", "s");
        simpleExpression = simpleExpression.Replace("ln", "l");
        simpleExpression = simpleExpression.Replace("sin", "n");
        simpleExpression = simpleExpression.Replace("cos", "c");
        simpleExpression = simpleExpression.Replace("tan", "t");
        simpleExpression = simpleExpression.Replace("  ", " ");
        
        return simpleExpression;
    }

    static int OperatorPriority(char operatorChar)
    {
        switch (operatorChar)
        {
            case '+': return 1;
            case '-': return 1;
            case '*': return 3;
            case '/': return 3;
            case '^': return 4; // pow(x)
            case 'p': return 4; // pow(x)
            case 's': return 4; // sqrt(x)
            case 'n': return 4; // sin(x)
            case 'c': return 4; // cos(x)
            case 't': return 4; // tan(x)
            case 'l': return 4; // ln(x)
            default: return 0;
        }
    }
}