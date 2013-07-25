using System;

class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        if (firstNumber > secondNumber)
        {
            int swapNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = swapNumber;
        }
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
    }
}

