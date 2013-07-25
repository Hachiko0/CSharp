using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IsDivisibleBy5and7
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Enter N: ");
        n = Int32.Parse(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            if(i%3!=0 && i%7!=0)
                Console.WriteLine(i+ " ");
        }
    }
}
