using System;
using System.IO;

/* Write a program that reads a text file containing a square matrix 
 * of numbers and finds in the matrix an area of size 2 x 2 with a maximal 
 * sum of its elements. The first line in the input file contains the size 
 * of matrix N. Each of the next N lines contain N numbers separated by space. 
 * The output should be a single number in a separate text file */

class MaximalSubSumMatrix
{
    static void Main()
    {
        int[,] matrix = null;
        StreamReader reader = null;
        try
        {
            reader = new StreamReader(@"..\..\input.txt");
        }
        catch (FileNotFoundException fileNotFound)
        {
            Console.WriteLine(fileNotFound.Message);
        }
        using (reader)
        {
            int size = int.Parse(reader.ReadLine());
            matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                string[] array = reader.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < array.Length; j++)
                {
                    matrix[i, j] = int.Parse(array[j]);
                }
            }
        }
        int maxSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                sum += matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    bestCol = j;
                    bestRow = i;
                }
                sum = 0;
            }
        }
        StreamWriter writer = new StreamWriter(@"..\..\output.txt");
        using (writer)
        {
            writer.WriteLine("The maximal submatrix is : ");
            writer.WriteLine("{0,3} {1,3}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1]);
            writer.WriteLine("{0,3} {1,3}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1]);
        }
    }
}

