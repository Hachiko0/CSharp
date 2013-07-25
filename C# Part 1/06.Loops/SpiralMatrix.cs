using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SpiralMatrix
{
    private static int value = 1;
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Enter N ( N< 20 ): ");
        n = Int32.Parse(Console.ReadLine());
        if (n >= 20)
        {
            Console.WriteLine("Invalid N.");
            return;
        }
        int[,] array = new int[n, n];
        int i, j, k;
        i = j = k = 0;
        for (int a = 0; a < n; a++)
        {
            for (int b = 0; b < n; b++)
            {
                array[a, b] = 0;
            }
        }
        int timeInWhile = 1;
        int iStart, iEnd, jStart, jEnd;
        iStart = iEnd = jStart = 0;
        jEnd = n;
        int zero = 0;
        while (value <= n * n)
        {
            goRight(iStart++, iEnd++, jStart++, jEnd--, ref array);
            goDown(jStart, jEnd, jEnd, jEnd, ref array);
            goLeft(jEnd, jEnd, jEnd - 1, zero, ref array);
            goUp(jEnd - 1, jStart, zero, zero++, ref array);
            timeInWhile++;
        }
        printMatrix(n, array);
    }
    private static void goRight(int iStart, int iEnd, int jStart, int jEnd, ref int[,] array)
    {
        for (int i = iStart; i <= iEnd; i++)
        {
            for (int j = jStart; j < jEnd; j++)
            {
                array[i, j] = value++;
            }
        }
    }
    private static void goDown(int iStart, int iEnd, int jStart, int jEnd, ref int[,] array)
    {
        for (int i = iStart; i <= iEnd; i++)
        {
            for (int j = jStart; j <= jEnd; j++)
            {
                array[i, j] = value++;
            }
        }
    }
    private static void goLeft(int iStart, int iEnd, int jStart, int jEnd, ref int[,] array)
    {
        for (int i = iStart; i <= iEnd; i++)
        {
            for (int j = jStart; j >= jEnd; j--)
            {
                array[i, j] = value++;
            }
        }
    }
    private static void goUp(int iStart, int iEnd, int jStart,int jEnd, ref int[,] array)
    {
        for (int i = iStart; i >= iEnd; i--)
        {
            for (int j = jStart; j <= jEnd; j++)
            {
                array[i, j] = value++;
            }
        }
    }
    private static void printMatrix(int n, int[,] array)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (array[i, j] / 10 < 1)
                {
                    Console.Write("{0}   ", array[i, j]);
                }
                else if (array[i, j] / 100 < 1)
                    Console.Write("{0}  ", array[i, j]);
                else
                    Console.Write("{0} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }
}
