using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
class FibonacciSum
{
    static void Main(string[] args)
    {
        int N;
        BigInteger sum;
        Console.WriteLine("Enter N: ");
        N = Int32.Parse(Console.ReadLine());
        Console.WriteLine();
        if (N == 0)
        {
            sum = 0;
        }
        else if (N == 1)
        {
            Console.Write("Fibonacci: 0 ");
            sum = 0;
        }
        else if (N == 2)
        {
            sum = 1;
            Console.Write("Fibonacci: 0 ");
            Console.Write("1 ");
        }
        else
        {
            Console.Write("Fibonacci: 0" + " ");
            Console.Write("1" + " ");
            sum = 1;
            for (int i = 1, j = 1, counter = 0; counter < N - 2; counter++)
            {
                sum += i;
                Console.Write(i + " ");
                int temp = i;
                i = i + j;
                j = temp;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The sum is: {0}", sum);
    }
}
