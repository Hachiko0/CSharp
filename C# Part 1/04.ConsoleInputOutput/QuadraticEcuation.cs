// Task 6 - Write a program that reads the coefficients a, b and c of a quadratic 
//equation ax2+bx+c=0 and solves it (prints its real roots).

using System;

class QuadraticEcuation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double x1;
        double x2;
        double D = b * b - (4 * a * c);
        if (D < 0)
        {
            Console.WriteLine("There are no real roots");
        }
        if (D == 0)
        {
            x1 = x2 = -b / (2 * a);
            Console.WriteLine("x1 = x2 = {0}", x1);
        }
        else
        {
            x1 = (-b + Math.Sqrt(D)) / (2 * a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("x1 = {0}",x1);
            Console.WriteLine("x2 = {0}",x2);
        }
    }
}

