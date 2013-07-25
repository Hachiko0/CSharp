using System;
using System.Text;
/* Write a method that reverses the digits of given decimal number. Example: 256  652 */

class ReverseDigit
{
    static decimal ReverseNumber(decimal number)
    {
        string stringToNumber = number.ToString();
        char[] letters = new char[stringToNumber.Length];
        letters = stringToNumber.ToCharArray();
        Array.Reverse(letters);
        StringBuilder reversedNumber = new StringBuilder();
        if (letters[letters.Length - 1] == '-')
        {
            reversedNumber.Append('-');
            for (int i = 0; i < letters.Length - 1; i++)
            {
                reversedNumber.Append(letters[i]);
            }
        }
        else
        {
            for (int i = 0; i < letters.Length; i++)
            {
                reversedNumber.Append(letters[i]);
            }
        }
        return decimal.Parse(reversedNumber.ToString());
    }
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal reversed = ReverseNumber(n);
        Console.WriteLine(reversed);
    }
}

