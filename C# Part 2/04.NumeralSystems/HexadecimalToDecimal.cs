using System;
/* Write a program to convert hexadecimal numbers to their decimal representation. */

class HexadecimalToDecimal
{
    static void Main()
    {
        string hexadecimal = "9786";
        int toDecimal = 0;
        for (int i = 0; i < hexadecimal.Length; i++)
        {
            if (hexadecimal[i] > 64 && hexadecimal[i] < 71)
            {
                int num = hexadecimal[i] - 64;
                num = (num + 10  - 1) * ((int)Math.Pow(16,hexadecimal.Length - 1 - i));
                toDecimal += num;
            }
            else
            {
                toDecimal += int.Parse(hexadecimal[i].ToString()) * (int)Math.Pow(16,hexadecimal.Length - 1 - i);
            }
        }
        Console.WriteLine(toDecimal);
    }
}
