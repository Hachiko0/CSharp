using System;

/* Modify your last program and try to make it work for
 * any number type, not just integer (e.g. decimal, float, byte, etc.). 
 * Use generic method (read in Internet about generic methods in C#). */

class GenericMethods
{
    static T Min<T>(params T[] arr)
    {
        dynamic min = arr[0];

        for (int i = 2; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }
    static T Max<T>(params T[] arr)
    {
        if (arr.Length == 2)
        {
            dynamic a = arr[0];
            dynamic b = arr[1];
            if (b > a)
            {
                a = b;
            }
            return a;
        }
        dynamic result = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            result = Max<T>(result, arr[i]);
        }
        return result;
    }
    static T Average<T>(params T[] arr)
    {
        dynamic result = arr[0]; ;
        for (int i = 1; i < arr.Length; i++)
        {
            result += arr[i];
        }
        return result / arr.Length;
    }
    static T Sum<T>(params T[] arr) // with recursion :) 
    {
        if (arr.Length == 2)
        {
            dynamic a = arr[0];
            dynamic b = arr[1];
            return a + b;
        }
        dynamic c = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            c = Sum<T>(c, arr[i]);
        }
        return c;
    }
    static T Product<T>(params T[] arr)
    {
        dynamic prod = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            prod = prod * arr[i];
        }
        return prod;
    }
    static void Main()
    {

        Console.WriteLine(Min<int>(5, 3, 2, 0, 11, 6, 7, -2));
        Console.WriteLine(Max<int>(5, 3, 2, 0, 11, 6, 7, -2));
        Console.WriteLine(Average<int>(5, 3, 2, 0, 11, 6, 7, -2));
        Console.WriteLine(Sum<int>(1, 2, 3, 4, 5, 6, 7, 8));
        Console.WriteLine(Product<double>(1.1,2.2,3.3,4.4,5.5));
    }
}
