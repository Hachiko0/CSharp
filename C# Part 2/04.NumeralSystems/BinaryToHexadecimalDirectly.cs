using System;

/* Write a program to convert binary numbers to hexadecimal numbers (directly). */

class BinaryToHexadecimalDirectly
{
    static void Main()
    {
        string binary = "111110100";
        char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F' };
        string hexadecimal = string.Empty;
        if (binary.Length % 4 != 0)
        {
            int i = 0;
            while ((binary.Length + i) % 4 != 0)
            {
                i++;
            }
            for (int j = 0; j < i; j++)
            {
                binary = "0" + binary;
            }
        }
        for (int i = 0; i < binary.Length; i = i + 4)
        {
            int sum = 0;
            int count = 3;
            for (int j = i; j < i + 4; j++)
            {
                int number = int.Parse(binary[j].ToString());
                int del = (int)Math.Pow(2, count);
                sum += number * del;
                count--;
            }
            if (sum < 10)
            {
                hexadecimal += sum;
            }
            else
            {
                hexadecimal += letters[sum % 10];
            }
        }
        Console.WriteLine(hexadecimal);
    }
}
