using System;
/* Write a program that finds the maximal increasing 
 * sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}. */

class MaxIncreasingSequence
{
    static void Main()
    {
        int[] arr = { 3, 2, 3, 4, 2, 2, 4, 5, 6, 7, };
        int len = 1;
        int maxLen = 1;
        int end = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1] - 1)
            {
                len++;
                continue;
            }
            else if (len > maxLen)
            {
                maxLen = len;
                end = i + 1;
            }
            len = 1;
        }
        if (len > maxLen)
        {
            maxLen = len;
            end = arr.Length;
        }
        for (int i = end - maxLen; i < end; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
