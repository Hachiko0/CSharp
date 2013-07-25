//Task 10 - Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;
using System.Threading;

class CalculateSumWithAccuracy
{
    static void Main()
    {
        double newSum = 1;
        double oldSum = 1;
        double sumDifference = 0;
        double i = 2;
        do
        {
            oldSum = newSum;
            if (i % 2 != 0) // 1 + 1/2 - 1/3 + 1/4 - 1/5 + 1/6 - 1/7 and so on ..
            {
                newSum = newSum - 1 / i; 
            }
            else
            {
                newSum = newSum + 1 / i;
            }
            i++;
            sumDifference = Math.Abs(newSum - oldSum);
        } while (sumDifference >= 0.001);
        Console.WriteLine(newSum);
        Console.WriteLine(oldSum);
        Console.WriteLine(sumDifference);
    }
}


