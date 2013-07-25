using System;
/* Write a program that reads two numbers N and K 
 * and generates all the variations of K elements from the set [1..N]. Example:
	N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3} */

class Program
{
    static int n = 3;
    static int k = 2;
    static int[] arr = new int[k];
    static void Variations(int[] arr, int index)
    {
        if (index == k)
        {
            for (int i = 0; i < k; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            return;
        }
        for (int i = 0; i < n; i++)
        {
            arr[index] = i + 1;
            Variations(arr, index + 1);
        }
    }
    static void Main()
    {
        Variations(arr, 0);
    }
}