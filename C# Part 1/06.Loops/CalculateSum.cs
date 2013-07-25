using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class CalculateSum
{
    static void Main(string[] args)
    {
        int N, X;
        Console.WriteLine("Enter N: ");
        N = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter X: ");
        X = Int32.Parse(Console.ReadLine());
        double sum = 1;
        for (int i = 1; i <= N; i++)
        {
            sum += calculateFact(i) / ((double)(Math.Pow(X, i)));
        }
        Console.WriteLine(sum);
    }
    private static int calculateFact(double n)
    {
        int factN = 1;
        for (int i = 2; i <= n; i++)
        {
            factN *= i;
        }
        //Console.WriteLine(factN);
        return factN;
    }
}
