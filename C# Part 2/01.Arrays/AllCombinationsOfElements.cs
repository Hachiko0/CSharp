using System;
/* Write a program that reads two numbers N and K and generates all the 
 * combinations of K distinct elements from the set [1..N]. Example:
	N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5} */

class AllCombinationsOfElements
{
    static int n = 5;
    static int k = 2;
    static int[] arr = new int[k];
    static void Combinations(int[] arr, int index, int number)
    {
        if (index == k)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            return;
        }
        for (int i = number; i < n; i++)
        {
            arr[index] = i;
            Combinations(arr, index + 1, i + 1);
        }
    }
    static void Main()
    {
        Combinations(arr, 0, 1);
    }
}

