using System;
using System.Collections.Generic;

namespace _02.DefineClassesPartTwo
{

    public class Matrix<T>
        where T : struct
    {
        private T[,] matrix;
        private int row;
        private int col;

        public Matrix(int row, int col)
        {
            this.Rows = row;
            this.Cols = col;
            matrix = new T[row, col];
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first == null || second == null)
            {
                throw new MatrixException("The both matrixes must be initialized");
            }
            if (first.Rows == second.Rows && first.Cols == second.Cols)
            {
                Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);
                for (int i = 0; i < result.Rows; i++)
                {
                    for (int j = 0; j < result.Cols; j++)
                    {
                        result[i, j] = (dynamic)first[i, j] + second[i, j];
                    }
                }
                return result;
            }
            else
            {
                throw new MatrixException("The two matrixes must have the same size of rows and cols");
            }
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first == null || second == null)
            {
                throw new MatrixException("The both matrixes must be initialized");
            }
            if (first.Rows == second.Rows && first.Cols == second.Cols)
            {
                Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);
                for (int i = 0; i < result.Rows; i++)
                {
                    for (int j = 0; j < result.Cols; j++)
                    {
                        result[i, j] = (dynamic)first[i, j] - second[i, j];
                    }
                }
                return result;
            }
            else
            {
                throw new MatrixException("The two matrixes must have the same size of rows and cols");
            }
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            //умножението на матрици работи само ако броят на редовете на първата матрица е равен
            //на броя на колоните на втората матрица. Пример : 2x3 и 3х2
            if (first == null || second == null)
            {
                throw new MatrixException("The both matrixes must be initialized");
            }
            int len = first.Rows;
            if (first.Rows == second.Cols)
            {
                Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < len; j++)
                    {
                        for (int k = 0; k < len; k++)
                        {
                            result[i, j] += (dynamic)first[i, k] * second[k, j];
                        }
                    }
                }
                return result;
            }
            else
            {
                throw new MatrixException("The two matrixes must be the same by size of rows and cols");
            }
        }


        public int Rows
        {
            get
            {
                return this.row;
            }
            private set
            {
                this.row = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.col;
            }
            private set
            {
                this.col = value;
            }
        }

        public T this[int row, int col]
        {
            get
            {
                if (checkOutOfRange(row, col))
                {
                    return matrix[row, col];
                }
                else
                {
                    throw new MatrixException("Index is OUT OF RANGE");
                }
            }
            set
            {
                if (checkOutOfRange(row, col))
                {
                    matrix[row, col] = value;
                }
                else
                {
                    throw new MatrixException("Index is OUT OF RANGE");
                }
            }
        }

        private bool checkOutOfRange(int row, int col)
        {
            return ((row >= 0 && row < this.Rows) && (col >= 0 && col < this.Cols));
        }
    }
}
