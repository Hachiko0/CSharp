using System;
using System.Collections.Generic;

class CalculateFactorial
{
    static void Main()
    {
        int n = 10;
        int[,] digits = new int[2, 200];
        List<int> result = new List<int>();
        int fac = 1;
        int[] compare = new int[2];
        for (int i = 2; i <= 10; i++) // calculate 10!
        {
            fac *= i;
        }
        while (fac > 0)
        {
            result.Add(fac % 10);
            fac = fac / 10;
        }
        for (int i = 11; i <= n; i++)
        {
            int counter = -1;
            int number = i;
            int carry = 0;
            while (number > 0)
            {
                counter++;
                int last = number % 10;
                number = number / 10;
                for (int j = 0; j < result.Count; j++)
                {
                    if (result[j] * last + carry < 10)
                    {
                        digits[counter, j] = result[j] * last + carry;
                        carry = 0;
                        compare[counter] = j;
                    }
                    else
                    {
                        digits[counter, j] = ((result[j] * last + carry) % 10);
                        carry = (result[j] * last + carry) / 10;
                        compare[counter] = j;
                    }
                }
                if (carry > 0)
                {
                    digits[counter, result.Count] = carry;
                    carry = 0;
                }
            }
            result.Clear();
            result.Add(digits[0, 0]);
            for (int k = 1; k <= compare[0]; k++)
            {
                if (digits[0, k] + digits[1, k - 1] + carry < 10)
                {
                    result.Add(digits[0, k] + digits[1, k - 1] + carry);
                    carry = 0;
                }
                else
                {
                    result.Add((digits[0, k] + digits[1, k - 1] + carry) % 10);
                    carry = 1;
                }
            }
            if (digits[1, compare[0]] + carry + digits[0, compare[0] + 1] < 10)
            {
                result.Add(digits[1, compare[0]] + carry + digits[0, compare[0] + 1]);
            }
            else
            {
                result.Add((digits[1, compare[0]] + carry + digits[0, compare[0] + 1]) % 10);
                result.Add((digits[1, compare[0]] + carry + digits[0, compare[0] + 1]) / 10);
            }
        }
        for (int i = result.Count - 1; i >=0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}
