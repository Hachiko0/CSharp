using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class CalculateFactorielsExpression
{
    static void Main(string[] args)
    {
        int N, K, difference;
        Console.WriteLine("Enter N: ");
        N = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter K (K>" + N + ")");
        K = Int32.Parse(Console.ReadLine());
        if (K <= N)
            Console.WriteLine("Wrong value of K.");
        else
        {
            BigInteger factN, factK, factDifference;
            factN = calculateFact(N);
            factK = calculateFact(K);
            Console.Write("{0}-{1}=",N,K);
            difference = N - K;
            Console.WriteLine(difference);
            factDifference = calculateFact(difference);
            BigInteger result = (factN * factK) / factDifference;
            Console.WriteLine("{0}!*{1}! / ({0}-{1})! = {2}",N,K,result);
        }
    }
    private static BigInteger calculateFact(BigInteger n)
    {
        BigInteger factN = 1;
        for (int i = 2; i <= n; i++)
        {
            factN *= i;
        }
        Console.WriteLine("{0}! = {1}",n,factN);
        return factN;
    }
}
