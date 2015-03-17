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
            Console.WriteLine(matrixA.GetValues(2)); 

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
            Console.WriteLine(matrixB.GetValues(2)); 

            //Creating a matrix of integers
            Console.WriteLine();
            Matrix<int> matrixC = new Matrix<int>(5, 2);
            counter = 1;
            for (int row = 0; row < matrixC.Rows; row++)
            {
                for (int col = 0; col < matrixC.Cols; col++)
                {
                    matrixC[row, col] = counter;
                    //counter++;
                }
            }
            Console.WriteLine("Printing matrix C");
            Console.WriteLine(matrixC.GetValues(2)); 

            //Test + operator on matrix of integers
            Console.WriteLine( );
            Console.WriteLine("Testing + operator (matrixA + matrixA)");
            Matrix<int> sumMatrix = matrixA + matrixA;
            Console.WriteLine(sumMatrix.GetValues(2)); 

            //Test + operator on matrix of chars
            Console.WriteLine();
            Console.WriteLine("Testing + operator (matrixB + matrixB)");
            Matrix<char> sumMatrixOfChars = matrixB + matrixB;
            Console.WriteLine(sumMatrixOfChars.GetValues(2));

            //Test - operator on matrix of integers
            Console.WriteLine();
            Console.WriteLine("Testing - operator (matrixA - matrixA)");
            Matrix<int> substractionMatrix = matrixA - matrixA;
            Console.WriteLine(substractionMatrix.GetValues(2)); 

            //Test - operator on matrix of chars
            Console.WriteLine();
            Console.WriteLine("Testing + operator (matrixB - matrixB)");
            Matrix<char> substractionMatrixOfChars = matrixB - matrixB;
            Console.WriteLine(substractionMatrixOfChars.GetValues(2));

            //Test * operator  on matrix of integers
            Console.WriteLine();
            Console.WriteLine("Testing - operator (matrixA * matrixC)");
            Matrix<int> multMatrix = matrixA * matrixC;
            Console.WriteLine(multMatrix.GetValues(5));

            //test true operator
            Console.WriteLine();
            Console.WriteLine("Testing \"true\" operator");
            Console.WriteLine(matrixA ? "MatrixA: Non-zero" : "MatrixA: Only zero");
            Console.WriteLine(matrixA-matrixA ? "MatrixA - MatrixA: Non-zero" : "MatrixA - MatrixA: Only zero");
            Console.ReadLine();


        }
    }
}
 