using System;
/* You are given an array of strings. 
 * Write a method that sorts the array by 
 * the length of its elements (the number of characters composing them). */

class SortArrayByLengthOfElements
{
    static void Main()
    {
        string[] arr = new string[] { "333", "55555", "1", "4444", "22" };
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i].Length > arr[j].Length)
                {
                    string tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }
        }
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }
}
