using System;
/*  1  8  9 16
    2  7 10 15
    3  6 11 14
    4  5 12 13
 */
class FillAndPrintMatrixB
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int colums = rows;
        int fill = 1;
        bool check = true;
        int[,] matrix = new int[rows, colums];
        int copy = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                if (!check)
                {
                    copy++;
                    fill = copy;
                    check = true;
                }
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[j, i] = fill;
                    fill++;
                }
            }
            else
            {
                check = false;
                fill--;
                fill += colums;
                copy = fill;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[j, i] = fill;
                    fill--;
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,3}",matrix[i,j]);
            }
            Console.WriteLine();
        }
    }
}

