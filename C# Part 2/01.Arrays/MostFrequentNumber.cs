using System;
/* Write a program that finds the most frequnt number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times) */

class Program
{
    static void Main()
    {
        int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int count = 0;
        int bestCount = 0;
        int mostFrequent = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
            }
            if (count > bestCount)
            {
                mostFrequent = i;
                bestCount = count;
            }
            count = 0;
        }
        Console.Write("{0} times -> ",bestCount);
        for (int i = 0; i < bestCount; i++)
        {
            Console.Write(arr[mostFrequent] + " ");
        }
    }
}

