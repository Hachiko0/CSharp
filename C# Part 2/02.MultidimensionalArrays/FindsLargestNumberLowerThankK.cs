using System;
/* Write a program, that reads from the console
 * an array of N integers and an integer K, sorts 
 * the array and using the method Array.BinSearch()
 * finds the largest number in the array which is ≤ K.  */

class FindsLargestNumberLowerThankK
{
    static void Main()
    {
        int[] arr = new int[] { 4, 1, 7, 5, 0, 11, -3 };
        Array.Sort(arr); // sort the array
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        int k = int.Parse(Console.ReadLine());
        int index = Array.BinarySearch(arr, k);
        if (index < -1)
        {
            Console.WriteLine("Largest number <= {1} is {0}", arr[~index - 1], k);
        }
        else if (index >= 0)
        {
            Console.WriteLine("Largest number <= {1} is {0}", arr[index],k);
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
}

