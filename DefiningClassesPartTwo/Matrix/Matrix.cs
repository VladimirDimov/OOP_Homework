
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
            if (a.Rows != b.Rows || a.Cols != b.Cols)
            {
                throw new ArithmeticException("The two matrixes must be with same sizes");
            }

            Matrix<T> newMatrix = new Matrix<T>(a.Rows, a.Cols);
            //TODO
            return newMatrix;
        }


        public void PrintMatrix(int padRight)
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
            Console.Write(builder.ToString());
        }
    }
}
