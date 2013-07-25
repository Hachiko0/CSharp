using System;
/* Write a method that adds two positive integer numbers
 * represented as arrays of digits (each array element 
 * arr[i] contains a digit; the last digit is kept in arr[0]).
 * Each of the numbers that will be added could have up to 10 000 digits. */

class AddIntegersRepresentedAsArray
{
    static int GetLastDigit(int number)
    {
        return number % 10;

    }
    static int[] AddIntegers(int x, int y)
    {
        int biggest = Math.Max(x, y);
        int smaller = Math.Min(x, y);
        int[] arr = new int[biggest.ToString().Length + 1];
        bool[] check = new bool[arr.Length];
        int i = 0;
        int more = 0;
        while (biggest > 0)
        {
            if (smaller > 0)
            {
                if (GetLastDigit(smaller) + GetLastDigit(biggest) + more > 9)
                {
                    arr[i] = ((GetLastDigit(smaller) + GetLastDigit(biggest)) + more) % 10;
                    more = 1;
                    check[i] = true;
                }
                else
                {
                    arr[i] = GetLastDigit(smaller) + GetLastDigit(biggest) + more;
                    more = 0;
                    check[i] = true;
                }
            }
            else
            {
                if (GetLastDigit(biggest) + more > 9)
                {
                    arr[i] = (GetLastDigit(biggest) + more) % 10;
                    more = 1;
                    check[i] = true;
                }
                else
                {
                    arr[i] = GetLastDigit(biggest) + more;
                    more = 0;
                    check[i] = true;
                }
            }
            smaller = smaller / 10;
            biggest = biggest / 10;
            i++;
        }
        if (more == 1)
        {
            arr[arr.Length - 1] = 1;
        }
        return arr;
    }
    static void Main()
    {
        int a = 1;
        int b = 999;
        int[] arr = AddIntegers(a, b);
        Array.Reverse(arr);
        if (arr[0] == 0) // print the array to see if the result is right
        {
            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
        else
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
        Console.WriteLine();
    }
}
