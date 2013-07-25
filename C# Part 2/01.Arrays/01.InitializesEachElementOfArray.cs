using System;
/*Write a program that allocates array of 20 integers 
 * and initializes each element by its index multiplied by 5.
 * Print the obtained array on the console. */

class InitializesEachElementOfArray
{
    static void Main()
    {
        int[] arr = new int[20];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i * 5;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

