using System;

/* Write a method that counts how many times 
 * given number appears in given array. Write 
 * a test program to check if the method is working correctly. */

class PrintYourName
{
    static void PrintName(string name)
    {
        Console.WriteLine("Heelo, {0}",name);
    }
    static void Main()
    {
        Console.Write("Enter your name: ");
        string input = Console.ReadLine();
        PrintName(input);
    }
}
