using System;
/* Sorting an array means to arrange its elements
 * in increasing order. Write a program to sort an
 * array. Use the "selection sort" algorithm: Find the 
 * smallest element, move it at the first position, find 
 * the smallest from the rest, move it at the second position, etc. */

class SelectionSort
{
    static void Main()
    {
        int[] arr = { 5, 4, 11, 0, 7, 4, 9, 13, 20, -5 };
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

