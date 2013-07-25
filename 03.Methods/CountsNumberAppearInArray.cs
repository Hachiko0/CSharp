using System;
/* Write a method that counts how many times 
 * given number appears in given array. Write 
 * a test program to check if the method is working correctly. */

class CountsNumberAppearInArray
{
    static int CountNumberInArray(int[] arr, int number)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
            {
                count++;
            }
        }
        return count;
    }
    static void Main()
    {
        int[] arr = new int[] { 4, 1,11, 5, 6, 7, 1, 9, 0, 11, 2,11 };
        Console.Write("Enter a number to check how many times appears: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} appears {1} times", n, CountNumberInArray(arr, n));
    }
}

