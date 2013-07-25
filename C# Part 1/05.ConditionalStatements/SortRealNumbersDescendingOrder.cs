using System;

class SortRealNumbersDescendingOrder
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a > b && b > c)
        {
            Console.WriteLine("{0} < {1} < {2}",c,b,a);
        }
        else if (a > c && c > b)
        {
            Console.WriteLine("{0} < {1} < {2}", b, c, a);
        }
        else if (b > a && a > c)
        {
            Console.WriteLine("{0} < {1} < {2}", c, a, b);
        }
        else if (b > c && c > a)
        {
            Console.WriteLine("{0} < {1} < {2}", a, c, b);
        }
        else if (c > a && a > b)
        {
            Console.WriteLine("{0} < {1} < {2}", b, a, c);
        }
        else //if (c > b && b > a) optional
        {
            Console.WriteLine("{0} < {1} < {2}", a, b, c);
        }

    }
}
