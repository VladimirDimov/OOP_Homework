using System;
using System.Linq;

class LongestString
{
    static void Main(string[] args)
    {
        string[] arr = new string[] { "abc", "defgh", "ij", "k", "lmnop", "qrs", "tuvw", "xy", "z" };

        int maxLength = arr.Max(str => str.Length);
        var myQuery = arr.Where(str => str.Length == maxLength);

        foreach (var str in myQuery)
            Console.WriteLine(str);
    }
}
