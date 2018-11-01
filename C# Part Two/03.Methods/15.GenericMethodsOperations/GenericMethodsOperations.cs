// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// Use variable number of arguments.
// * Modify your last program and try to make it work for any number type, not just integer 
// (e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).
using System;
using System.Collections.Generic;

class GenericMethodsOperations
{
    static void Main()
    {
        int minInt = CalculateMinimum(1, -1, 3, 10, -20, 15, 22);
        int maxInt = CalculateMaximum(1, -1, 3, 10, -20, 15, 22);
        int sumInt = CalculateSum(1, -1, 3, 10, -20, 15, 22);
        int averageInt = CalculateAverage(1, -1, 3, 10, -20, 15, 22);
        int productInt = CalculateProduct(1, -1, 3, 10, -20, 15, 22);

        Console.WriteLine("INT (1, -1, 3, 10, -20, 15, 22)\nmin = {0}\nmax = {1}\nsum= {2}\naverage = {3}\nproduct = {4}\n", 
            minInt, maxInt, sumInt, averageInt, productInt);

        long minLong = CalculateMinimum(13513616316l, -13136136l, 135136136l, 135136l);
        long maxLong = CalculateMaximum(13513616316l, -13136136l, 135136136l, 135136l);
        long sumLong = CalculateSum(13513616316l, -13136136l, 135136136l, 135136l);
        long averageLong = CalculateAverage(13513616316l, -13136136l, 135136136l, 135136l);
        long productLong = CalculateProduct(13513616316l, -13136136l, 135136136l, 135136l);

        Console.WriteLine("LONG (13513616316l, -13136136l, 135136136l, 135136l)\nmin = {0}\nmax = {1}\nsum = {2}\naverage = {3}\nproduct = {4} - OVERFLOW\n", 
            minLong, maxLong, sumLong, averageLong, productLong);

        float minFloat = CalculateMinimum(10.5f, -200.125f, 19.65f, 195.24f, 120.5f, -20.8f);
        float maxFloat = CalculateMaximum(10.5f, -200.125f, 19.65f, 195.24f, 120.5f, -20.8f);
        float sumFloat = CalculateSum(10.5f, -200.125f, 19.65f, 195.24f, 120.5f, -20.8f);
        float averageFloat = CalculateAverage(10.5f, -200.125f, 19.65f, 195.24f, 120.5f, -20.8f);
        float productFloat = CalculateProduct(10.5f, -200.125f, 19.65f, 195.24f, 120.5f, -20.8f);

        Console.WriteLine("FLOAT (10.5f, -200.125f, 19.65f, 195.24f, 120.5f, -20.8f)\nmin = {0}\nmax = {1}\nsum = {2}\naverage = {3}\nproduct = {4}\n", 
            minFloat, maxFloat, sumFloat, averageFloat, productFloat);

        decimal minDecimal = CalculateMinimum(1024.20m, -356m, 1000000.001m, -102040.24567554m, -10.1325136m, 0.135m);
        decimal maxDecimal = CalculateMaximum(1024.20m, -356m, 1000000.001m, -102040.24567554m, -10.1325136m, 0.135m);
        decimal sumDecimal = CalculateSum(1024.20m, -356m, 1000000.001m, -102040.24567554m, -10.1325136m, 0.135m);
        decimal averageDecimal = CalculateAverage(1024.20m, -356m, 1000000.001m, -102040.24567554m, -10.1325136m, 0.135m);
        decimal productDecimal = CalculateProduct(1024.20m, -356m, 1000000.001m, -102040.24567554m, -10.1325136m, 0.135m);

        Console.WriteLine("DECIMAL (1024.20m, -356m, 1000000.001m, -102040.24567554m, -10.1325136m, 0.135m)min = {0}\nmax = {1}\nsum = {2}\naverage = {3}\nproduct = {4}\n", 
            minDecimal, maxDecimal, sumDecimal, averageDecimal, productDecimal);
    }

    static T CalculateMinimum<T>(params T[] parameters)
    {
        if (parameters.GetLength(0) == 2)
        {
            dynamic x = parameters[0];
            dynamic y = parameters[1];
            return x < y ? x : y;
        }
        else
        {
            dynamic result = parameters[0];
            for (int i = 1; i < parameters.Length; i++)
            {
                result = CalculateMinimum(result, parameters[i]);
            }
            return result;
        }
    }

    static T CalculateMaximum<T>(params T[] parameters)
    {
        if (parameters.GetLength(0) == 2)
        {
            dynamic x = parameters[0];
            dynamic y = parameters[1];
            return x > y ? x : y;
        }
        else
        {
            dynamic result = parameters[0];
            for (int i = 0; i < parameters.GetLength(0); i++)
            {
                result = CalculateMaximum<T>(result, parameters[i]);
            }
            return result;
        }
    }

    static T CalculateSum<T> (params T[] parameters)
    {
        dynamic sum = 0;
        foreach (T x in parameters)
        {
            sum += x;
        }
        return sum;
    }

    static T CalculateAverage<T> (params T[] parameters)
    {
        dynamic sum = CalculateSum(parameters);
        return sum / parameters.GetLength(0);
    }

    static T CalculateProduct<T>(params T[] parameters)
    {
        dynamic product = 1;
        foreach (T x in parameters)
        {
            product *= x;
        }
        return product;
    }
}

