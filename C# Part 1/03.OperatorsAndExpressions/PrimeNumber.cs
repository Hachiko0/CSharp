using System;

class PrimeNumber
{
    static void Main()
    {
        int n = 37;
        int i = 2;
        int maxDevider = n / 2 - 1;
        bool isPrime = true;
        while (i < maxDevider && isPrime)
        {
            if (n % i == 0)
            {
                isPrime = false;
            }
            i++;
        }
        if (isPrime)
        {
            Console.WriteLine("{0} is prime", n);
        }
        else
        {
            Console.WriteLine("{0} is not prime", n);
        }
    }
}

