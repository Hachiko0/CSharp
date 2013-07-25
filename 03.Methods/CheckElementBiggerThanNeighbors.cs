using System;

/* Write a method that checks if the element at given 
 * position in given array of integers is bigger than 
 * its two neighbors (when such exist). */

namespace BiggerThanNeighbours
{
    public class CheckElementBiggerThanNeighbors
    {
        public static int CheckNeighors(int[] arr, int index)
        {
            if (index > 0 && index < arr.Length - 1)
            {
                if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1])
                {
                    return 1;
                    
                }
            }
            return -1;
        }
        static void Main()
        {
            int[] arr = new int[] { 1, 6, 4, 7, 0, 9, -3, 11, 15, 3, 8 };
            int index = int.Parse(Console.ReadLine());
            int result = CheckNeighors(arr, index);
            if (result == 1)
            {
                Console.WriteLine("{0} is bigger than {1} and {2}", arr[index], arr[index - 1], arr[index + 1]);
            }
            else if (index == 0 || index == arr.Length - 1)
            {
                Console.WriteLine("{0} does not have 2 neighbors", arr[index]);
            }
            else
            {
                Console.WriteLine("{0} is not bigger than {1} and {2}", arr[index], arr[index - 1], arr[index + 1]);
            }
        }
    }
}

