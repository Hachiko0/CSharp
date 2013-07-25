using System;

/* Write a program to convert hexadecimal numbers to binary numbers (directly). */

class HexadecimalToBinaryDirectly
{
    static string ConvertToHexadecimal(char ch,bool check = false)
    {
        string result = string.Empty;
        string tmp = string.Empty;
        int number = 0;
        if (check) // its a number
        {
            number = int.Parse(ch.ToString());
        }
        else // its a character like "A","B","C","D","E" or "F"
        {
            number = (ch - 64) + 9; // asci code of 'A' is 65
        }
        while (number > 0)
        {
            tmp += number % 2;
            number /= 2;
        }
        if (check) // допълваме с 0 ако битовете са по - малко от 4 
        {
            for (int j = tmp.Length; j < 4; j++)
            {
                tmp += "0";
            }
        }
        for (int j = tmp.Length - 1; j >= 0; j--)
        {
            result += tmp[j];
        }
        return result;
        
    }
    static void Main()
    {
        string hexadecimal = "ABCDEF";
        string binary = string.Empty;
        for (int i = 0; i < hexadecimal.Length; i++)
        {
            if (hexadecimal[i] >= 48 && hexadecimal[i] <= 57) // the char is a digit
            {

                binary += ConvertToHexadecimal(hexadecimal[i], true);
            }
            else
            {
                binary += ConvertToHexadecimal(hexadecimal[i], false);
            }
        }
        Console.WriteLine("Result: {0}",binary);
    }
}

