using System;

class FillAndPrintMatrixD
{
    public static int x = 0;
    public static int y = 0;
    public static int z = 0;
    public static int w = 0;
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] mat = new int[n, n];
        int len = 0;
        int fill = 1;
        //go down
        while (fill <= n * n)
        {
            for (int i = len; i <= len; i++)
            {
                for (int j = len; j < n - len; j++)
                {
                    mat[j, i] = fill;
                    fill++;
                    x = j;
                }
            }
            PrintMatrix(mat); // keep track of the matrix, you can remove it :) 
            //go right
            for (int i = x; i <= x; i++)
            {
                for (int j = 1 + len; j < n - len; j++)
                {
                    mat[i, j] = fill;
                    fill++;
                    y = j;
                }
            }
            if (fill == n * n + 1)
            {
                break;
            }
            PrintMatrix(mat); // keep track of the matrix, you can remove it :) 
            //go up
            for (int i = y - 1; i >= len; i--)
            {
                z = i;
                for (int j = y; j <= y; j++)
                {
                    mat[i, j] = fill;
                    fill++;
                    w = j;
                }
            }
            PrintMatrix(mat); // keep track of the matrix, you can remove it :) 
            //go left
            for (int i = z; i <= z; i++)
            {
                for (int j = w - 1; j > 0 + len; j--)
                {
                    mat[i, j] = fill;
                    fill++;
                }
            }
            PrintMatrix(mat); // keep track of the matrix, you can remove it :) 
            len++;
        }
        PrintMatrix(mat); // print the final matrix 
    }
    public static void PrintMatrix(int[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("{0,3}", mat[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
