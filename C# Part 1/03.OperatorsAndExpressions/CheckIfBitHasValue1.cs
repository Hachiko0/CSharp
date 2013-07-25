using System;

class CheckIfBitHasValue1
{
    static void Main()
    {
        int number = 95;
        int pos = 6;
        int mask = 1;
        mask = mask << pos;
        number = number & mask;
        number = number >> pos;
        bool bitIsOne = number == 1;
        Console.WriteLine("The bit at position {0} is 1 : {1}", pos, bitIsOne);
    }
}

