using System;

class MaxElementsMatrix
{
    public static int[,] mat;
    static void Main()
    {
        Console.Write("Enter 0 to generate random matrix or 1 for already generated matrix: ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            mat = new int[,] {
                     {5,4,0,1,9},
                     {11,3,6,4,0},
                     {10,9,5,3,1},
                     {12,6,2,-3,4},
                     {1,2,3,4,5}
                     };
        }
        else if (choice == 0)
        {
            Random random = new Random();
            Console.Write("Enter rows: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter cols: ");
            int m = int.Parse(Console.ReadLine());
            mat = new int[n, m];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = random.Next(-11, 41); // fill the matrix with numbers between 10 and 40
                }
            }
        }
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("{0,4}", mat[i, j]); // print the matrix
            }
            Console.WriteLine();
        }
        int sum = 0;
        int bestSum = 0;
        int bestI = 0;
        int bestJ = 0;
        for (int i = 0; i < mat.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < mat.GetLength(1) - 2; j++)
            {
                sum = mat[i, j] + mat[i, j + 1] + mat[i, j + 2] + mat[i + 1, j] + mat[i + 1, j + 1] + mat[i + 1, j + 2]
                    + mat[i + 2, j] + mat[i + 2, j + 1] + mat[i + 2, j + 2];
                //if we want to calculate the sum automatically we must use 2 more nested loops
                //for (int k = i; k <= i + 2; k++)
                //{
                //    for (int w = j; w <= i + 2; w++)
                //    {
                //        sum += mat[k, w];
                //    }
                //}
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestI = i;
                    bestJ = j;
                }
                sum = 0;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The sum of the best submatrix is : {0}",bestSum);
        for (int i = bestI; i <= bestI + 2; i++)
        {
            for (int j = bestJ; j <= bestJ + 2; j++)
            {
                Console.Write(mat[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

