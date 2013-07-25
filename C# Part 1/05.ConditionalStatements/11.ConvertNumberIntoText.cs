using System;
class Proba
{
    static void Main()
    {
        string[] specials = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven",
                            "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
                            "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        string[] tens = { "Fail", "Fai1", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninenty" };
        string[] sup = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] hundreds = {"","One hundred","Two hundred","Three hundred","Four hundred","Five hundred","Six hundred",
                                "Seven hundred","Eight hundred","Nine hundred"};
        int n = 0;
        do
        {
            n = int.Parse(Console.ReadLine());
        } while (n < 0 || n > 999); // n must be between 0 and 999
        if (n >= 0 && n <= 19) // 0 < n < 20
        {
            Console.WriteLine(specials[n]);
        }
        else if (n >= 20 && n <= 99) // 19 < n < 100
        {
            Console.WriteLine(tens[n / 10] + " " + sup[n % 10]);
        }
        else if (n >= 100 && n <= 999) // 99 < n << 1000
        {
            if (n % 100 <= 19) //if n is between 100 and 999 and the last 2 numbers are betwen 1 and 19
            {
                if (n % 100 == 0) // if n is 100,200,300 and so on
                {
                    Console.WriteLine(hundreds[n / 100]);
                }
                else
                {
                    Console.WriteLine(hundreds[n / 100] + " and " + specials[n % 100].ToLower());
                }
            }
            else if (n % 10 == 0)
            {
                Console.WriteLine(hundreds[n / 100] + " and " + tens[(n % 100) / 10].ToLower());
            }
            else if (n % 10 != 0)
            {
                Console.WriteLine(hundreds[n / 100] + " and " + tens[(n % 100) / 10].ToLower() + " " + sup[n % 10]);
            }
        }
    }
}