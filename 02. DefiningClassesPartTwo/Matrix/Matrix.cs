
namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Matrix<T>
    {
        private T[,] matrix;

        public Matrix() : this(1,1)
        {

        }

        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }

        public int Rows
        {
            get { return this.matrix.GetLength(0); }
        }

        public int Cols
        {
            get { return this.matrix.GetLength(1); }
        }

        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set 
            {
                try
                {
                    this.matrix[row, col] = value;
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArrayTypeMismatchException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            if (a.Rows != b.Rows || a.Cols != b.Cols)
            {
                throw new ArithmeticException("The two matrixes must be with same sizes");
            }

            Matrix<T> newMatrix = new Matrix<T>(a.Rows, a.Cols);
            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Cols; col++)
                {
                    newMatrix[row, col] = (T)((dynamic)a[row, col] + (dynamic)b[row, col]);
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            if (a.Rows != b.Rows || a.Cols != b.Cols)
            {
                throw new ArithmeticException("The two matrixes must be with same sizes");
            }

            Matrix<T> newMatrix = new Matrix<T>(a.Rows, a.Cols);
            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Cols; col++)
                {
                    newMatrix[row, col] = (T)((dynamic)a[row, col] - (dynamic)b[row, col]);
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {          
            if (a.Cols != b.Rows)
            {
                throw new ArithmeticException("The first matrix columns must equal the second matrix rows");
            }

            Matrix<T> newMatrix = new Matrix<T>(a.Rows, b.Cols);

            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < b.Cols; col++)
                {
                    T curCellValue = (dynamic)0;
                    for (int i = 0; i < a.Cols; i++)
                    {
                        curCellValue += ((dynamic)a[row, i] * (dynamic)b[i, col]);
                    }
                    newMatrix[row, col] = curCellValue;
                }
            }
            return newMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            return IsNonZero(matrix);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return !IsNonZero(matrix);
        }

        private static bool IsNonZero(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public string GetValues(int padRight)
        {
            var builder = new StringBuilder();
            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    string curvalue = this.matrix[row, col].ToString().PadRight(padRight);
                    builder.AppendFormat("{0} ", curvalue);
                }
                builder.AppendLine();
            }
            return builder.ToString();
        }
    }
}
