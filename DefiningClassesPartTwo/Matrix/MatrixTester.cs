using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MatrixTester
    {
        static void Main()
        {
            //Creating a matrix of integers
            Matrix<int> matrixA = new Matrix<int>(5,5);
            int counter = 1;
            for (int row = 0; row < matrixA.Rows; row++)
            {
                for (int col = 0; col < matrixA.Cols; col++)
                {
                    matrixA[row, col] = counter;
                    counter++;
                }
            }
            Console.WriteLine("Printing matrix A");
            matrixA.PrintMatrix(2);

            //Creating a matrix of chars
            Console.WriteLine();
            Matrix<char> matrixB = new Matrix<char>(5, 5);
            for (int row = 0; row < matrixB.Rows; row++)
            {
                for (int col = 0; col < matrixB.Cols; col++)
                {
                    matrixB[row, col] = 'b';
                }
            }
            Console.WriteLine("Printing matrix B");
            matrixB.PrintMatrix(2);
            
            //Test + operator on matrix of integers
            Console.WriteLine( );
            Console.WriteLine("Testing + operator (matrixA + matrixA)");
            Matrix<int> sumMatrix = matrixA + matrixA;
            sumMatrix.PrintMatrix(2);

            //Test + operator on matrix of chars
            Console.WriteLine();
            Console.WriteLine("Testing + operator (matrixB + matrixB)");
            Matrix<char> sumMatrixOfChars = matrixB + matrixB;
            sumMatrixOfChars.PrintMatrix(2);

            //Test - operator on matrix of integers
            Console.WriteLine();
            Console.WriteLine("Testing - operator (matrixA - matrixA)");
            Matrix<int> substractionMatrix = matrixA - matrixA;
            substractionMatrix.PrintMatrix(2);

            //Test - operator on matrix of chars
            Console.WriteLine();
            Console.WriteLine("Testing + operator (matrixB - matrixB)");
            Matrix<char> substractionMatrixOfChars = matrixB - matrixB;
            substractionMatrixOfChars.PrintMatrix(2);
            Console.WriteLine((char)('b' - 'b'));
            Console.ReadLine();
        }
    }
}
