using System;
/* We are given an array of integers and a number
 * S. Write a program to find if there exists a 
 * subset of the elements of the array that has a sum S.
 * Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6) */
class SubsetSums
{
    static void Main()
    {
        int[] arrayOfNumbers = { 2, 1, 2, 4, 3, 5, 2, 5, 2, 4, 3, 7, 2, 9, 11, 2, 4, 3, 5, 2, 6 };
        int maxi = (int)Math.Pow(2, arrayOfNumbers.Length) - 1;
        int S = int.Parse(Console.ReadLine());
        bool hasSum = false;
        for (int i = 1; i <= maxi; i++)
        {
            int currentSum = 0;
            for (int j = 1; j <= arrayOfNumbers.Length; j++)
            {
                if (((i >> (j - 1)) & 1) == 1)
                {
                    currentSum += arrayOfNumbers[j - 1];
                }
            }
            if (currentSum == S)
            {
                hasSum = true;
            }
        }
        if (hasSum)
        {
            Console.WriteLine("Yes.");
        }
        else
        {
            Console.WriteLine("No.");
        }
    }
}