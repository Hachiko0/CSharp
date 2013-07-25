using System;
/* Write a program to convert decimal numbers to their binary representation. */

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        string binary = string.Empty;
        while (number > 0)
        {
            binary += number % 2;
            number /= 2;
        }
        for (int i = binary.Length - 1; i >= 0; i--)
        {
            Console.Write(binary[i]);
        }
        Console.WriteLine();
    }
}
