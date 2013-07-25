using System;

class ExchangeFirstBitsWithLast
{
    static void Main()
    {
        int[] arr = new int[6]; 
        //arr will countain the bits of the number later:
        long number = 16777216;
        int mask = 1;
        int i = 1;
        int j = 1;
        while (j <= 3)
        {
            mask = 1 << j + 2; // 3rd bit,then 4th bit,then 5th bit
            arr[j - 1] = (int)(number & mask) >> j + 2;
            j++;
            mask = 1;
        }
        //arr[0] = 3rd bit
        //arr[1] = 4th bit
        //arr[2] = 5th bit
        while (i <= 3)
        {
            mask = 1 << i + 23; // 24th bit,then 25th,26th
            arr[i + 2] = (int)(number & mask) >> i + 23;
            i++;
            mask = 1;
        }
        //arr[3] = 24th bit
        //arr[4] = 25th bit
        //arr[5] = 26th bit
        for (int k = 0; k < 3; k++)
        {
            mask = 1;
            if (arr[k] == 0) // if 3rd bit == 0
            {
                mask = ~(1 << k + 24);
                number = number & mask;
            }
            else // if 3rd bit == 1
            {
                mask = 1 << k+ 24;
                number = number | mask;
            }
        }
        for (int k = 3; k < 6; k++)
        {
            mask = 1;
            if (arr[k] == 0) // if 24th bit == 0
            {
                mask = ~(1 << k);
                number = number & mask;
            }
            else // if 24th bit == 1
            {
                mask = 1 << k;
                number = number | mask;
            }
        }
        Console.WriteLine(number);
    }
}

