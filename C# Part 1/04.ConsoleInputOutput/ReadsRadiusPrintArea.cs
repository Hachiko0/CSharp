//Task 2 - Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class ReadsRadiusPrintArea
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * Math.PI * radius;
        Console.WriteLine("Area : {0}",area);
    }
}
