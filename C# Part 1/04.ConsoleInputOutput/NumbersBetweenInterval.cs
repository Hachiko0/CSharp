//Task 4 - Write a program that reads two positive integer numbers and prints 
//how many numbers p exist between them such that the reminder of the division 
//by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class NumbersBetweenInterval
{
    static void Main()
    {
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = startNumber; i <= endNumber; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write(i + " ");
                count++; // count how many numbers has remainder 0 when being devided by 5
            }
        }
        Console.WriteLine();
        Console.WriteLine("{0} numbers between {1} and {2} have remainder 0 when devided by 5",count,startNumber,endNumber);
    }
}

