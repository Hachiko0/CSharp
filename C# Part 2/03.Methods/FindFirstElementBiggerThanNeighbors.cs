using System;
using BiggerThanNeighbours;
/* Write a method that returns the index 
 * of the first element in array that is
 * bigger than its neighbors, or -1, if there’s no such element.
Use the method from the previous exercise. */

class FindFirstElementBiggerThanNeighbors
{
    static int FindElementBiggerNeighbors(int[] arr)
    {
        for (int i = 1; i < arr.Length - 1; i++)
        {
            //we use the method from the previous task - to do this the class and the method we want to use
            //from the previus task must be public and have namespace,then we must add the namespace with 
            //the keyword using
            if (CheckElementBiggerThanNeighbors.CheckNeighors(arr, i) == 1)
            {
                return i;
            }
        }
        return -1;
    }
    static void Main()
    {
        int[] arr = new int[] { 9, 8, 7, 6, 5, 4, 1, 2, 1 };
        int result = FindElementBiggerNeighbors(arr);
        if (result != -1)
        {
            Console.WriteLine("The index of the first element which is bigger than his neigbours is {0}", result);
        }
        else
        {
            Console.WriteLine("There is no such element");
        }
    }
}


