// Problem 5. 64 Bit array
// =======================
// Define a class BitArray64 to hold 64 bit values inside an ulong value.
// Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
namespace _5._64BitArray
{
    using System;

    class Program
    {
        static void Main()
        {
            BitArray64 number = new BitArray64(8);
            Console.WriteLine("Print number");
            Console.WriteLine("{0} -> {1}", number.Number, number.ToString());
            number[0] = 1;
            Console.WriteLine("Print number with modified bit at position [0]:");
            Console.WriteLine("{0} -> {1}", number.Number, number.ToString());

            // Testing IEnumerable
            Console.WriteLine();
            Console.WriteLine("Testing IEnumerable:");
            Console.WriteLine("foreach:");
            foreach (var bit in number)
            {
                Console.Write("{0} ", bit);
            }
            Console.WriteLine();
            Console.WriteLine("for loop");
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("Position {0}->{1}",i, number[i]);
            }

            // Test operators == and !=
            Console.WriteLine();
            Console.WriteLine("Testing operators == and != ...");
            BitArray64 numberSeven = new BitArray64(7);
            BitArray64 numberNine = new BitArray64(9);
            Console.WriteLine("{0} == {1} -> {2}", number, numberSeven, number == numberSeven);
            Console.WriteLine("{0} == {1} -> {2}", number, numberNine, number == numberNine);
        }
    }
}
