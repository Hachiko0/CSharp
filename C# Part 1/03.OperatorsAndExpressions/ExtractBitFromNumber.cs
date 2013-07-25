using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExtractValue
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int pos = int.Parse(Console.ReadLine());
        int mask = 1 << pos;
        int nAndMask = number & mask;
        int bit = nAndMask >> pos;
        Console.WriteLine("The bit at position {0} in the number {1} is {2}",pos,number,bit);
    }
}
