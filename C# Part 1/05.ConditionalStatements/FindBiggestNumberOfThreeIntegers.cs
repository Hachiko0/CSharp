using System;

class FindBiggestNumberOfThreeIntegers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (a > b && a > c)
        {
            Console.WriteLine("{0} is the biggest number",a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("{0} is the biggest number",b);
        }
        else //if (c > a && c > b) optinal
        {
            Console.WriteLine("{0} is the biggest number", c);
        }
    }
}

