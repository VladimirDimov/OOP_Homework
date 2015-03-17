namespace GenericClass
{
    using System;

    public class GenericTester
    {
        public static void Main()
        {
            GenericList<int> testList = new GenericList<int>();
            for (int i = 0; i < 8; i++)
            {
                testList.Add(i);
            }

            // testList.RemoveAt(1);
            // testList.Add(9);
            for (int i = 0; i < 3; i++)
            {
                testList.RemoveAt(i);
            }

            testList.InsertAt(1, 200);
            testList.Add(100);
            Console.WriteLine(testList.IndexOf(7));
            Console.WriteLine(testList.ToString());

            Console.WriteLine("Returning Min value ...");
            Console.WriteLine(testList.Min<int>());
            testList.Clear();

            // Testing string genericList
            Console.WriteLine();
            Console.WriteLine("Testing <string> generic list ...");
            GenericList<string> testString = new GenericList<string>();
            testString.Add("abc");
            testString.Add("def");
            testString.Add("ghi");
            Console.WriteLine("Returning Min value ...");
            Console.WriteLine(testString.Min<string>());
            Console.WriteLine("Returning Max value ...");
            Console.WriteLine(testString.Max<string>());

            Console.ReadLine();
        }
    }
}
