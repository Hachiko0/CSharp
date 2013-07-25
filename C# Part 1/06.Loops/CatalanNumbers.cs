using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
class CatalanNumbers
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Enter N (N>=0): ");
        n = Int32.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("Wrong N");
            return;
        }
        BigInteger result = (calculateFact(2 * n)) / ((calculateFact(n + 1)) * calculateFact(n));
        Console.WriteLine("The {0} Catalan number is {1}", n, result);
    }
    private static BigInteger calculateFact(BigInteger n)
    {
        BigInteger factN = 1;
        for (int i = 2; i <= n; i++)
        {
            factN *= i;
        }
        return factN;
    }
}
