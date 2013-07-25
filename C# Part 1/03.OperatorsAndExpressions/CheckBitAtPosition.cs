using System;

class CheckBitAtPosition
{
    static void Main()
    {
        int n = 27;
        int pos = 3;
        int mask = 1;
        mask = mask << pos;
        n = n & mask;
        n = n >> pos;
        Console.WriteLine("The bit at {0} position is {1}", pos, n);
    }
}

