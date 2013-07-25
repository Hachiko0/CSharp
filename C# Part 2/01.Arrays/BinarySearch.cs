// Write a program that finds the index of given 
// element in a sorted array of integers by using
// the binary search algorithm (find it in Wikipedia)

using System;

class BinarySearch
{
    static void Main()
    {
        int[] arr = { 6, 4, 7, 0, 9, 22, 11, 15, 3, -5, 5 };
        Array.Sort(arr); // binary search works ONLY with SORTED arrays
        Console.Write("Enter a number to look for : ");
        int number = int.Parse(Console.ReadLine());
        int left = 0;
        int right = arr.Length - 1;
        while (true) 
        {
            int mid = (left + right) / 2;
            int middle = arr[mid];
            if (number == middle)
            {
                Console.WriteLine("{0} found at {1} position",number,mid);
                return;
            }
            else if (left == right)
            {
                Console.WriteLine("{0} not found ", number);
                return;
            }
            else if (number > middle)
            {
                left = mid + 1;
            }
            else if (number < middle)
            {
                right = mid - 1;
            }
        }
    }
}

