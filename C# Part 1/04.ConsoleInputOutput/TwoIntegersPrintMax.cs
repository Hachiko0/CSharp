//Task 5 - Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class TwoIntegersPrintMax
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int biggestNumber = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("The bigger number is {0}", biggestNumber);
    }
}
