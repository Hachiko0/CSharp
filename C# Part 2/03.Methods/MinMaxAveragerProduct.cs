using System;

/* Write methods to calculate minimum, maximum, average, sum 
 * and product of given set of integer numbers. Use variable number of arguments */

class MinMaxAveragerProduct
{
    static int Minimum(params int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
            }
        }
        return min;
    }
    static int Maximum(params int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }
    static int Average(params int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum % arr.Length;
    }
    static int Sum(params int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    static int Product(params int[] arr)
    {
        int prod = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            prod *= arr[i];
        }
        return prod;
    }
    static void Main()
    {
        Console.WriteLine(Minimum(3,0,11,6,4,-1,-4));
        Console.WriteLine(Maximum(3,0,11,6,4,-1,-4));
        Console.WriteLine(Average(1, 2, 3, 4, 5, 6));
        Console.WriteLine(Sum(10,111,1111));
        Console.WriteLine(Product(1,2,3,4,5,6));
    }
}
