using System;
using System.Collections.Generic;
/* Write a program that finds all prime numbers 
 * in the range [1...10 000 000]. Use the sieve
 * of Eratosthenes algorithm (find it in Wikipedia). */

class SieveOfEratosthenes
{
    static void Main()
    {
        int size = 1000000;
        bool[] check = new bool[size]; // all elements are false by default
        for (int i = 2; i < Math.Sqrt(check.Length); i++)
        {
            if (check[i] == false)
            {
                for (int j = i + i; j < size; j += i)
                {
                    check[j] = true;
                }
            }
        }
        for (int i = 2; i < size; i++)
        {
            if (check[i] == false)
            {
                Console.WriteLine(i);
            }
        }
    }
}


