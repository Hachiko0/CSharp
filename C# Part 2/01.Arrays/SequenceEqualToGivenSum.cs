using System;
/* Write a program that finds in given array of integers a 
 * sequence of given sum S (if present). 
 * Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5} */
class SequenceEqualToGivenSum
{
    static void Main()
    {
        int[] arr = { 11, 13, -2, 4, 2, 5, 6};
        Console.Write("Enter a sum: ");
        int s = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum = arr[i];
            int count = 0;
            for (int j = i; j < arr.Length; j++)
            {
                if (sum == s)
                {
                    for (int w = i; w <= i + count; w++) // we will print all sequnces equal to the sum if there are more than 1
                    {
                        Console.Write(arr[w] + " ");
                    }
                    Console.WriteLine();
                    break;
                }
                if (j + 1 < arr.Length) // if we dont check this we will go out of the array
                {
                    sum += arr[j + 1];
                    count++;
                }
            }
        }
    }
}

