using System;

class CheckGender
{
    static void Main()
    {
        Console.Write("Enter your gender (f/m): ");
        char gender = char.Parse(Console.ReadLine());
        bool isMale = (gender == 'm' || gender == 'M'); //return true only if gender is m or M
        Console.WriteLine("You are male : {0}", isMale);
    }
}
