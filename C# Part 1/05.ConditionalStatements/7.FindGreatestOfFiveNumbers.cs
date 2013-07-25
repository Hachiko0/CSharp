using System;

class FindGreatestOf5Variables
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double greatest = a;
        if (greatest < b)
        {
            greatest = b;
        }
        if (greatest < c)
        {
            greatest = c;
        }
        if (greatest < d)
        {
            greatest = d;
        }
        if (greatest < e)
        {
            greatest = e;
        }
        Console.WriteLine("Greatest number : {0}", greatest);
    }
}
