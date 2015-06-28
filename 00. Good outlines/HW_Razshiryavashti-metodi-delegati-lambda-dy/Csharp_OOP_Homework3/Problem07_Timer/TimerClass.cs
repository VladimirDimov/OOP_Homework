using System;

class TimerClass
{
    delegate void MethodToExecute();

    static void Main(string[] args)
    {
        ExecuteMethodEvery(7, HelloWorldMethod);
    }

    static void ExecuteMethodEvery(int seconds, MethodToExecute myMethod)
    {
        if (myMethod == null) return;

        while(Console.KeyAvailable == false)
        {
            myMethod();
            System.Threading.Thread.Sleep(seconds*10);
        }
    }

    static void HelloWorldMethod()
    {
        Console.WriteLine("Hello World");
    }
}
