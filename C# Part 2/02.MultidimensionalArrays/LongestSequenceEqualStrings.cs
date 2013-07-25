using System;
/* We are given a matrix of strings of size N x M. 
 * Sequences in the matrix we define as sets of several 
 * neighbor elements located on the same line, column or
 * diagonal. Write a program that finds the longest sequence
 * of equal strings in the matrix */
class Program
{
    static void Main()
    {
        string[,] mat = {
                            {"11","12","13","14"},
                            {"21","22","23","24"},
                            {"31","32","33","34"},
                            {"41","42","43","44"},
                            {"51","52","53","54"}
                        };
        int count = 0;
        int len = 1;
        int maxLen = 1;
        string best = string.Empty;
        //check colums
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1) - 1; j++)
            {
                count++;
                if (mat[i, j] == mat[i, j + 1])
                {
                    len++;
                    if (len > maxLen)
                    {
                        maxLen = len;
                        best = mat[i, j];
                    }
                }
                else
                {
                    len = 1;
                }
            }
        }
        len = 1;
        //check rows
        for (int i = 0; i < mat.GetLength(1); i++)
        {
            for (int j = 0; j < mat.GetLength(0) - 1; j++)
            {
                if (mat[j, i] == mat[j + 1, i])
                {
                    len++;
                    if (len > maxLen)
                    {
                        maxLen = len;
                        best = mat[j, i];
                    }
                }
                else
                {
                    len = 1;
                }
            }
        }
        len = 1;

        //check diagonals left to right
        int counter = 0;
        for (int i = 0; i < mat.GetLength(1) && counter < mat.GetLength(0); i++)
        {
            int copy = i;
            if (counter >= 1)
            {
                copy = mat.GetLength(1);
            }
            for (int j = mat.GetLength(0) - 1 - counter; j >= 0; j--)
            {
                if (i + 1 < mat.GetLength(1) && j - 1 >= 0)
                {
                    string first = mat[j, i];
                    string second = mat[j - 1, i + 1];
                    if (mat[j, i] == mat[j - 1, i + 1])
                    {
                        len++;
                        if (len > maxLen)
                        {
                            maxLen = len;
                            best = mat[j, i];
                        }
                        i++;
                    }
                    else
                    {
                        len = 1;
                        i++;
                    }
                }
                else break;
            }
            if (copy + 2 < mat.GetLength(1))
            {
                i = copy;
            }
            else
            {
                i = -1;
                counter++;
            }
            len = 1;
        }
        //check diagonals right to left
        len = 1;
        int zero = 1;
        bool check = false;
        for (int i = mat.GetLength(0) - 1; i > 0; i--)
        {
            if (check) zero = mat.GetLength(1) - 2;
            for (int j = mat.GetLength(1) - 1; j > zero; j--)
            {
                for (int k = i, w = j; k > 0; k--, w--)
                {
                    if (k - 1 >= 0 && w - 1>= 0)
                    {
                        check = true;
                        string first = mat[k, w];
                        string second = mat[k - 1, w - 1];
                        if (mat[k, w] == mat[k - 1, w - 1])
                        {
                            len++;
                            if (len > maxLen)
                            {
                                maxLen = len;
                                best = mat[k, w];
                            }
                        }
                        else len = 1;
                    }
                    else break;
                }
            }
        }
        for (int i = 0; i < maxLen; i++)
        {
            Console.Write(best + " ");
        }
    }
}