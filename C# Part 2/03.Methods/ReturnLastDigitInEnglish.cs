using System;

/* Write a method that returns the last digit 
 * of given integer as an English word. Examples: 
 * 512  "two", 1024  "four", 12309  "nine". */

class ReturnLastDigitInEnglish
{
    static string LastDigitIntoWord(int number)
    {
        string[] digits = new string[10] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        int lastDigit = number % 10;
        return digits[lastDigit];
    }
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Last digit : {0}",LastDigitIntoWord(n));
    }
}

