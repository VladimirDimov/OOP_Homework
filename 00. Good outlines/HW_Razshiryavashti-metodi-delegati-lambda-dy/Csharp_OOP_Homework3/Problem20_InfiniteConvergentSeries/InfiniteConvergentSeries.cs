using System;

class InfiniteConvergentSeries
{
    delegate double TermFunction(int n);

    static void Main(string[] args)
    {
        double series1 = EvaluateSeries(ExampleSeries1);
        Console.WriteLine("{0:0.000}", series1);

        double series2 = EvaluateSeries(ExampleSeries2);
        Console.WriteLine("{0:0.000}", series2);

        double series3 = EvaluateSeries(ExampleSeries3);
        Console.WriteLine("{0:0.000}", series3);
    }

    static double EvaluateSeries(TermFunction term)
    {
        int n = 0;
        double result = 0;
        while (Math.Abs(term(n)) >= 0.00001)
        {
            result = result + term(n);
            n++;
        }
        return result;
    }

    static double ExampleSeries1(int n)
    {
        return 1.0 / Math.Pow(2, n);
    }

    static double ExampleSeries2(int n)
    {
        double denominator = 1.0;
        for (int i = 2; i <= n; i++)
            denominator = denominator * i;
        return 1.0 / denominator;
    }
    static double ExampleSeries3(int n)
    {
        if (n == 0) return 1.0;

        if (n % 2 == 0)
            return -1.0 / Math.Pow(2, n);
        else
            return 1.0 / Math.Pow(2, n);
    }
}
