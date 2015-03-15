using System;
using System.Text;

namespace StringBuilderSubstring
{
    class Tester
    {
        static void Main()
        {
            var builder = new StringBuilder();
            builder.Append("123456789");
            Console.WriteLine(builder.SubString(1, 3));  //Print: 234
        }
    }
}
