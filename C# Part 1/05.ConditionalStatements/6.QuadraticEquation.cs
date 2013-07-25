using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double D = b * b - 4 * a * c;
        double x1, x2 = 0;
        if (D < 0)
        {
            Console.WriteLine("No real roots!");
            return;
        }
        else if (D == 0)
        {
            x1 = x2 = -b / (2 * a);
            Console.WriteLine("x1 = x2 = {0}", x1);
        }
        else
        {
            x1 = (-b - Math.Sqrt(D)) / (2 * a);
            x2 = (-b + Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("x1 = {0}", x1);
            Console.WriteLine("x2 = {0}", x2);
        }
    }
}
