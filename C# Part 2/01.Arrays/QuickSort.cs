using System;
/*Write a program that sorts an array of strings 
 * using the quick sort algorithm (find it in Wikipedia).
 */ 
class QuickSort
{
    public static void Quick(int[] arr, int left, int right)
    {
        int i = left;
        int j = right;
        int middle = arr[(i + j) / 2];
        while (i <= j)
        {
            while (arr[i] < middle)
            {
                i++;
            }
            while (arr[j] > middle)
            {
                j--;
            }
            if (i <= j)
            {
                int tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
                i++;
                j--;
            }
        }
        if (left < j)
        {
            Quick(arr, left, j);
        }
        if (i < right)
        {
            Quick(arr, i, right);
        }
    }
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
    static void Main()
    {
        int[] arr = { 1, 5, 7, 8, 4, 3, 4, 9, 0 };
        Quick(arr, 0, arr.Length - 1);
        PrintArray(arr);
    }
}

