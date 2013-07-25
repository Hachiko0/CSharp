using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NsizedMatrix
{
    static void Main(string[] args)
    {
        int n;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Enter N size for the matrix ( N<20 ): ");
        n = Int32.Parse(Console.ReadLine());
        if (n >= 20)
        {
            Console.WriteLine("N must be < 20");
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            int temp = i;
            for (int j = 1; j <= n; j++)
            {
                Console.Write(temp++ + " ");
            }
            Console.WriteLine();
        }

    }
}
