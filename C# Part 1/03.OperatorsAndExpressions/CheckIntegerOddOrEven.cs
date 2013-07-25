using System;

class CheckIntegerOddOrEven
{
    static void Main()
    {
        int number = 44;
        if (number % 2 == 0)
        {
            Console.WriteLine("{0} is even", number);
        }
        else
        {
            Console.WriteLine("{0} is odd", number);
        }
    }
}
