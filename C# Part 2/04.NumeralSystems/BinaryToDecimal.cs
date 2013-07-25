using System;

/* Write a program to convert binary numbers to their decimal representation. */

class Program
{
    static void Main()
    {
        int n = 1100011;
        int sum = 0;
        string numberToString = n.ToString();
        int len = numberToString.Length;
        for (int i = len - 1; i >= 0; i--)
        {
            sum += int.Parse(numberToString[i].ToString()) * (int)Math.Pow(2,i);
        }
        Console.WriteLine(sum);
    }
}
