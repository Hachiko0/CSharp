using System;
using System.Collections.Generic;
using System.Text;

class PrintASCIITable
{
    static void Main(string[] args)
    {
        Console.Title = "ASCII Table";
        Console.OutputEncoding = Encoding.Unicode;
        for (int i = 1; i <= 255; i++)
        {
            if (i >= 7 && i <= 10 || i == 13 || i == 32) // special cases which cant be printed
            {
                switch (i)
                {
                    case 7: Console.WriteLine("{0} = BEL", i); break;
                    case 8: Console.WriteLine("{0} = Backspace", i); break;
                    case 9: Console.WriteLine("{0} = Horizontal Tab", i); break;
                    case 10: Console.WriteLine("{0} = New Line", i); break;
                    case 13: Console.WriteLine("{0} = Return", i); break;
                    case 32: Console.WriteLine("{0} = Space", i); break;
                    default: break;
                }
            }
            else
            {
                Console.WriteLine("{0} = {1}", i, (char)i);
            }
        }
    }
}
