using System;
/*  1  8  9 16
    2  7 10 15
    3  6 11 14
    4  5 12 13 */

class FillAndPrintMatrix
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int colums = rows;
        int fill = 1;
        int[,] matrix = new int[rows, colums];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                matrix[j, i] = fill;
                fill++;
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                Console.Write("{0,-3}",matrix[i,j]);
            }
            Console.WriteLine();
        }
    }
}

