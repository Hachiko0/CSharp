using System;

class ModifyIntegerChaningBitAtPosition
{
    static void Main()
    {
        int n = 5;
        int pos = 3;
        int v = 1;
        if (v == 1)
        {
            v = v << pos;
            n = n | v;
            Console.WriteLine(n);
        }
        else // v is 0
        {
            int mask = 1;
            mask = ~(mask << pos);
            n = n & mask;
            Console.WriteLine(n);
        }
    }
}

