using System;
using System.Collections.Generic;

/* Write a method that return the maximal element 
 * in a portion of array of integers starting at given 
 * index. Using it write another method that sorts an array 
 * in ascending / descending order. */

class MaximalElementInPortion
{
    public static int w = 0;
    static int MaxElement(int index, int[] arr)
    {
        w = -1;
        int max = arr[index];
        for (int i = index + 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                w = i;
            }
        }
        return max;
    }
    static int[] SortArray(int[] arr) // sort in descending order 
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int tmp = arr[i];
            arr[i] = MaxElement(i, arr);
            if (w != -1)
            {
                arr[w] = tmp;
            }

        }
        return arr;
    }
    static void Main()
    {
        int[] arr = new int[] { 1, 5, 0, 3, -5, 6, 11, 2, 9, 4 };
        arr = SortArray(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

