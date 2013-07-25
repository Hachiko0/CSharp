using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintAllNumbersToN
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Enter N: ");
        n = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write(i+ " ");
        }
        Console.WriteLine();
    }
}
