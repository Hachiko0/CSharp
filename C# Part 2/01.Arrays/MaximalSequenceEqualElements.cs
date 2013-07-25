using System;
/* Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}. */

class MaximalSequenceEqualElements
{
    static void Main()
    {
        int[] arr = { 2, 1, 1, 1, 3, 0, 2, 2, 2, 2 };
        int len = 1;
        int end = 0;
        int maxLen = 1;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                len++;
                continue;
            }
            else if (len > maxLen)
            {
                maxLen = len;
                end = i;
            }
            len = 1;
        }
        if (len > maxLen)
        {
            maxLen = len;
            end = arr.Length - 1;
        }
        for (int i = end; i < end + maxLen; i++)
        {
            Console.Write(arr[end] + " ");
        }
    }
}