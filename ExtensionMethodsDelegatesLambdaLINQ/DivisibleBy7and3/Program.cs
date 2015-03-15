//  Problem 6. Divisible by 7 and 3
//  ===============================
//  Write a program that prints from given array of integers all numbers that 
//  are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. 
//  Rewrite the same with LINQ.

namespace DivisibleBy7and3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static void Main()
        {
            int[] numbers = { 1, 2, 3, 6, 7, 10, 42, 21, 35, 34, 63 };

            // Solve using predicate
            Console.WriteLine("Using predicate:");
            var devisibleByThreeAndSeven = numbers.Where(x => DevisibleBy(x, 3, 7));

            foreach (var number in devisibleByThreeAndSeven)
            {
                Console.WriteLine(number);
            }

            // Solveusing LINQ
            Console.WriteLine();
            Console.WriteLine("Using LINQ qury:");
            devisibleByThreeAndSeven =
                from number in numbers
                where number % 3 == 0
                where number % 7 == 0
                select number;
            foreach (var number in devisibleByThreeAndSeven)
            {
                Console.WriteLine(number);
            }
        }

        private static bool DevisibleBy(int number, params int[] devideBy)
        {
            foreach (var devider in devideBy)
            {
                if (number % devider != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
