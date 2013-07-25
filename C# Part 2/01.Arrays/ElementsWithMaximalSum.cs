using System;
/* Write a program that reads two integer numbers N and K 
 * and an array of N elements from the console. Find in the 
 * array those K elements that have maximal sum. */

class ElementsWithMaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int maxSum = 0;
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("[{0}] = ",i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        //we will just sort the array in ascending order and the biggest numbers will be at the end
        // selection sort or we can just use Array.Sort(arr);
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
        // we add the last k elements to maxSum because we know they are the biggest(we sorted them)
        for (int i = arr.Length - 1; i >= arr.Length - k; i--) 
        {
            maxSum += arr[i];
        }
        Console.WriteLine(maxSum);
    }
}

