// Problem 7. Timer
// ================
// Using delegates write a class Timer that can execute certain method at each t seconds.
namespace Timer
{
using System;
using System.Threading.Tasks;

    public class Tester
    {
        static void Main()
        {
            // Execute method SayHi in one second interval
            Timer timer = new Timer();
            timer.TimeIntervaInSeconds = 1;
            timer.Method = SayHi;
            timer.Execute();
        }

        static void SayHi()
        {
            Console.WriteLine("Hi!");
        }
    }
}
