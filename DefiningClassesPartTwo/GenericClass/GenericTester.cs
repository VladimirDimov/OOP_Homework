
namespace GenericClass
{
    using System;
    //using GenericClass;

    class GenericTester
    {
        static void Main()
        {
            GenericList<int> testList = new GenericList<int>();
            for (int i = 0; i < 8; i++)
            {
                testList.Add(i);
            }

            //testList.RemoveAt(1);
            //testList.Add(9);
            for (int i = 0; i < 3; i++)
            {
                testList.RemoveAt(i);
            }
            testList.InsertAt(1, 200);
            testList.Add(100);
            Console.WriteLine(testList.IndexOf(7));
            Console.WriteLine(testList.ToString());
            testList.Clear();
            Console.ReadLine();
        }

    }
}
