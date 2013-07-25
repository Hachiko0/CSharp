using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
class DivideTwoFactoriels
{
    static void Main(string[] args)
    {
        BigInteger N, K;
        Console.WriteLine("Enter N: ");
        N = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter K (K<N)");
        K = Int32.Parse(Console.ReadLine());
        if (K >= N)
            Console.WriteLine("Wrong value of K.");
        else
        {
            BigInteger factN = N;
            BigInteger factK = K;
            for (int i = 2; i < N; i++)
            {
                factN *= i;
                if (i < K)
                    factK *= i;
            }
            Console.WriteLine("{0}! = {1}",N,factN);
            Console.WriteLine("{0}! = {1}", K, factK);
            Console.WriteLine("{0} / {1} = {2}",factN,factK,factN / factK);
            Console.WriteLine();
        }
    }
}
