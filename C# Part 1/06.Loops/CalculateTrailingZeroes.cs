using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class CalculateTrailingZeroes
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Enter n: ");
        n = Int32.Parse(Console.ReadLine());
        BigInteger factorielN = calculateFact(n);
        Console.WriteLine(factorielN);
        Console.WriteLine("Number of trailing zeroes: {0}",countTrailingZeroes(factorielN));

    }
    private static int countTrailingZeroes(BigInteger n)
    {
        int count = 0;
        while (n != 0)
        {
            if (n % 10 == 0)
                count++;
            else
                break;
            n = n / 10;
        }
        return count;
    }
    private static BigInteger calculateFact(BigInteger n)
    {
        BigInteger factN = 1;
        for (int i = 2; i <= n; i++)
        {
            factN *= i;
        }
        Console.WriteLine("{0}! = {1}", n, factN);
        return factN;
    }
}
