using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    class Tester
    {
        static void Main()
        {
            //Testing with int[]
            Console.WriteLine("Testing with int[] {1,2,3,4}");
            int[] collectionInt = { 1, 2, 3, 4 };
            Console.WriteLine("Sum: " + collectionInt.Sum<int>());
            Console.WriteLine("Product: {0}", collectionInt.Product<int>());
            Console.WriteLine("Min: {0}", collectionInt.Min<int>());
            Console.WriteLine("Max: {0}", collectionInt.Max<int>());
            Console.WriteLine("Average: {0}", collectionInt.Average<int>());

            //Testing with string[] {"1", "2", "3", "4"}
            Console.WriteLine();
            Console.WriteLine("Testing with string[] {\"1\", \"2\", \"3\", \"4\"}");
            string[] collectionString = { "1", "2", "3", "4" };
            Console.WriteLine("Sum: {0}", collectionString.Sum<string>());

            //Testing with char[] {'a', 'b'}
            Console.WriteLine();
            char[] collectionChar = { 'a', 'b' };
            Console.WriteLine("Testing with char[] {'a', 'b'}");
            Console.WriteLine("Sum: " + collectionChar.Sum<char>());
            Console.WriteLine("Min: {0}", collectionChar.Min<char>());
            Console.WriteLine("Min: {0}", collectionChar.Max<char>());
            Console.WriteLine("Average: {0}", collectionChar.Average<char>());
        }
    }
}
