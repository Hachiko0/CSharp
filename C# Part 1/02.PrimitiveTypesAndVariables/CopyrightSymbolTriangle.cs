using System;
using System.Text;

class CopyrightSymbolTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char copyright = '\u00a9';
        for (int i = 1; i < 4 ; i++) // first option
        {
            Console.Write(new string(copyright, i)); //we print the char(copyright) i-times every single iteration
            Console.WriteLine();
        }
        Console.WriteLine(); // second option - 2 for loops
        for (int i = 0; i < 3; i++) // count the lines
        {
            for (int j = 0; j < i + 1; j++) // count the char of every line
            {
                Console.Write(copyright);
            }
            Console.WriteLine();
        }
    }
}
