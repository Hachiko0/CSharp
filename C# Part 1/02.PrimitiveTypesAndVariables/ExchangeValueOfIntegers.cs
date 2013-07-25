using System;

class ExchangeValueOfIntegers
{
    static void Main()
    {
        int firstValue = 5;
        int secondValue = 10;
        Console.WriteLine("Before swapping: firstValue = {0} ; secondValue = {1}", firstValue, secondValue);
        int swapIntegers = firstValue;
        firstValue = secondValue;
        secondValue = swapIntegers;
        Console.WriteLine("After swapping: firstValue = {0} ; secondValue = {1}", firstValue, secondValue);
    }
}

