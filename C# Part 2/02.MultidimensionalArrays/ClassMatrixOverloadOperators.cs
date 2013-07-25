using System;
/* Write a class Matrix, to holds a matrix of integers. 
 * Overload the operators for adding, subtracting and 
 * multiplying of matrices, indexer for accessing the matrix content and ToString(). */
class Matrix
{
    private int[,] mat;
    public Matrix(int i, int j)
    {
        this.mat = new int[i, j];
        this.Fill(); // initiliaze each element of the matrix
    }
    public int this[int x, int y] // indexer for accessing the matrix
    {
        get
        {
            return this.mat[x, y];
        }
        set
        {
            this.mat[x, y] = value;
        }
    }
    private void Fill() 
    {
        int counter = 0;
        for (int i = 0; i < mat.GetLength(0); i++)
        {

            for (int j = 0; j < mat.GetLength(1); j++)
            {
                this.mat[i, j] = counter;
                counter++;
            }
        }
        // 0 1 2
        // 3 4 5
        // 6 7 8
    }
    public static Matrix operator +(Matrix a, Matrix b)
    {
        Matrix c = new Matrix(a.mat.GetLength(0), a.mat.GetLength(1));
        for (int i = 0; i < a.mat.GetLength(0); i++) // 1st option
        {
            for (int j = 0; j < a.mat.GetLength(1); j++)
            {
                c[i, j] = a[i, j] + b[i, j];
            }
        }

        //for (int i = 0; i < a.mat.GetLength(0); i++) // 2nd option
        //{
        //    for (int j = 0; j < a.mat.GetLength(1); j++)
        //    {
        //        c.mat[i, j] = a.mat[i, j] + b.mat[i, j];
        //    }
        //}
        return c;
    }
    public static Matrix operator -(Matrix a, Matrix b)
    {
        Matrix c = new Matrix(a.mat.GetLength(0), a.mat.GetLength(1));
        for (int i = 0; i < a.mat.GetLength(0); i++)
        {
            for (int j = 0; j < a.mat.GetLength(1); j++)
            {
                c[i, j] = a[i, j] - b[i, j];
            }
        }
        return c;
    }
    public static Matrix operator *(Matrix a, Matrix b)
    {
        Matrix c = new Matrix(a.mat.GetLength(0), a.mat.GetLength(1));
        for (int i = 0; i < a.mat.GetLength(0); i++)
        {
            for (int j = 0; j < a.mat.GetLength(0); j++)
            {
                for (int k = 0; k < a.mat.GetLength(0); k++)
                {
                    c[i, j] += a[i, k] * b[k, j];
                }
            }
        }
        return c;
    }
    public override string ToString()
    {
        string s = string.Empty;
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                s += mat[i, j].ToString() + " ";
            }
            s += '\n'; // new line 
        }
        return s;
    }
    public void Print() // print the matrix
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("{0,4}", mat[i, j]);
            }
            Console.WriteLine();
        }
    }
}
class ClassMatrixOverloadOperators
{
    static void Main()
    {
        Matrix first = new Matrix(3, 3);
        Matrix second = new Matrix(3, 3);
        Matrix third = new Matrix(3, 3);
        Console.WriteLine("Overload + operator :");
        third = first + second;
        third.Print();
        Console.WriteLine("Overload - operator :");
        third = first - second;
        third.Print(); // it will show 0 because the two matrices have the same values
        Console.WriteLine("Overload * operator :");
        third = first * second;
        third.Print();
        string s = third.ToString(); //overloaded method
        Console.WriteLine(s);
    }
}

