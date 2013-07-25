using System;

class AgeAfter10years
{
    static void Main()
    {
        Console.Write("Please enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("You will be {0} years old after 10 years",age + 10);
    }
}
