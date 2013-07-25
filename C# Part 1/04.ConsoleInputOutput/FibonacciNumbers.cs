//Task 9 - Write a program to print the first 100 members of the sequence of
//Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

class FibonacciNumbers
{
    static void Main()
    {
        ulong firstNumber = 0;
        ulong secondNumber = 1;
        ulong nextNumber = 0;
        for (int i = 0; i < 100; i++)
        {
            Console.Write(i + 1 + ".");
            Console.WriteLine(nextNumber);
            nextNumber = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = nextNumber;
        }
    }
}
