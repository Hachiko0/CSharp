using System;
/*  7 11 14 16
    4  8 12 15
    2  5  9 13
    1  3  6 10 
 */
class FillAndPrintMatrixC
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int fill = 2;
        int start = 2;
        int[,] mat = new int[n,n];
        mat[n - 1, 0] = 1;
        for (int i = n - start; i >= 0; i = n - start)
        {
            for (int j = 0; j < start; j++)
            {
                mat[i, j] = fill;
                fill++;
                i++;
            }
            start++;
        }
        start = 1;
        for (int i = 0; i < n - start; i++)
        {
            for (int j = start; j <= n - 1; j++)
            {
                mat[i, j] = fill;
                i++;
                fill++;
            }
            i = -1;
            start++;
        }
        PrintMatrix(mat);
    }
    public static void PrintMatrix(int[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("{0,3}",mat[i,j]);
            }
            Console.WriteLine();
        }
    }
}
