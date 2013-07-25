using System;

class DigitIntoText
{
    static void Main()
    {
        Console.Write("Enter a digit: ");
        int digit = 0;
        do
        {
            digit = int.Parse(Console.ReadLine());
            if (digit > 9)
            {
                Console.Write("Please try again: ");
            }
        } while (digit > 9);
        switch (digit)
        {
            case 0: Console.WriteLine("zero"); break;
            case 1: Console.WriteLine("one"); break;
            case 2: Console.WriteLine("two"); break;
            case 3: Console.WriteLine("three"); break;
            case 4: Console.WriteLine("four"); break;
            case 5: Console.WriteLine("five"); break;
            case 6: Console.WriteLine("six"); break;
            case 7: Console.WriteLine("seven"); break;
            case 8: Console.WriteLine("eight"); break;
            case 9: Console.WriteLine("nine"); break;
            default: Console.WriteLine("Error"); break;
        }
    }
}

