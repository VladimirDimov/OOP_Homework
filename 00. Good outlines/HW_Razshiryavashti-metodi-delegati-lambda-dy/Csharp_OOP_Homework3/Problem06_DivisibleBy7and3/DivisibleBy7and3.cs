using System;
using System.Linq;

class DivisibleBy7and3
{
    static void Main(string[] args)
    {
        int[] arr = new int []{ 4, 6, 14, 3, 21, 25, 28, 3, 35, 42 };

        var myQuery = arr
            .Where(x => x % 7 == 0)
            .Where(x => x % 3 == 0);

        foreach (var number in myQuery)
            Console.WriteLine(number);

        Console.WriteLine();

        var myQuery2 =
            from x in arr
            where x % 7 == 0
            where x % 3 == 0
            select x;

        foreach (var number in myQuery2)
            Console.WriteLine(number);


        
    }
}
