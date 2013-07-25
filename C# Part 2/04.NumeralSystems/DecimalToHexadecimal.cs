using System;
/* Write a program to convert decimal numbers to their hexadecimal representation. */

class DecimalToHexadecimal
{
    static void Main()
    {
        int n = 11259375;
        string hexadecimal = string.Empty;
        string[] letters = new string[] { "A", "B", "C", "D", "E", "F" };
        while (n > 0)
        {
            int last = n % 16;
            if (last > 9)
            {
                hexadecimal += letters[last % 10];
            }
            else
            {
                hexadecimal += last.ToString();
            }
            n /= 16;
        }
        for (int i = hexadecimal.Length - 1; i >= 0; i--)
        {
            Console.Write(hexadecimal[i]);
        }
        Console.WriteLine();
    }
}
