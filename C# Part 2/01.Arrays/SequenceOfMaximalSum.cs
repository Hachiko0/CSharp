using System;
/* Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -? {2, -1, 6, 4} */

class SequenceOfMaximalSum
{
    static void Main()
    {
        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int sum = 0;
        int bestSum = 0;
        int start = 0;
        int end = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                sum += arr[j];
                if (sum > bestSum)
                {
                    start = i;
                    end = j;
                    bestSum = sum;
                }
            }
            sum = 0;
        }
        for (int i = start; i <= end; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

