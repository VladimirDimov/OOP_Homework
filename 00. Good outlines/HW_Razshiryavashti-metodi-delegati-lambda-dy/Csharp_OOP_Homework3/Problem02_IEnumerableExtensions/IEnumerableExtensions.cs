using System;
using System.Collections.Generic;
using System.Linq;

class IEnumerableExtensions
{
    static void Main(string[] args)
    {
        int[] arr = { 2, 1, 4, 3 };
        int sum = arr.Sum<int>();
        int prod = arr.Product<int>();
        int min = arr.Min<int>();
        int max = arr.Max<int>();
        double avg = arr.Average<int>();
        Console.WriteLine(sum);
        Console.WriteLine(prod);
        Console.WriteLine(min);
        Console.WriteLine(max);
        Console.WriteLine(avg);

        Console.WriteLine();

        List<double> list = new List<double>();
        list.Add(2.3);
        list.Add(3.0);
        list.Add(4.1);
        list.Add(2.2);
        double sum1 = list.Sum<double>();
        double prod1 = list.Product<double>();
        double min1 = list.Min<double>();
        double max1 = list.Max<double>();
        double avg1 = list.Average<double>();
        Console.WriteLine(sum1);
        Console.WriteLine(prod1);
        Console.WriteLine(min1);
        Console.WriteLine(max1);
        Console.WriteLine(avg1);

        Console.WriteLine();

        Queue<float> queue = new Queue<float>();
        queue.Enqueue(-2.1f);
        queue.Enqueue(-1.3f);
        queue.Enqueue(0.2f);
        queue.Enqueue(0.7f);
        float sum2 = queue.Sum<float>();
        float prod2 = queue.Product<float>();
        float min2 = queue.Min<float>();
        float max2 = queue.Max<float>();
        double avg2 = queue.Average<float>();
        Console.WriteLine(sum2);
        Console.WriteLine(prod2);
        Console.WriteLine(min2);
        Console.WriteLine(max2);
        Console.WriteLine(avg2);
    }
}

static class Extensions
{
    public static T Sum<T>(this IEnumerable<T> iEnum)
    {
        T sum = (dynamic)0;
        foreach (var element in iEnum)
            sum = sum + (dynamic)element;
        return sum;
    }
    public static T Product<T>(this IEnumerable<T> iEnum)
    {
        T prod = (dynamic)1;
        foreach (var element in iEnum)
            prod = prod * (dynamic)element;
        return prod;
    }
    public static T Min<T>(this IEnumerable<T> iEnum)
        where T: IComparable<T>
    {
        T min = iEnum.FirstOrDefault<T>();
        foreach (var element in iEnum)
            if (min.CompareTo(element) > 0)
                min = element;
        return min;
    }
    public static T Max<T>(this IEnumerable<T> iEnum)
        where T : IComparable<T>
    {
        T max = iEnum.FirstOrDefault<T>();
        foreach (var element in iEnum)
            if (max.CompareTo(element) < 0)
                max = element;
        return max;
    }
    public static double Average<T>(this IEnumerable<T> iEnum)
    {
        double count = 0.0;
        T sum = (dynamic)0;
        foreach (var element in iEnum)
        {
            sum = sum + (dynamic)element;
            count = count + 1.0;
        }
        return (double)(dynamic)sum / count;
    }
}