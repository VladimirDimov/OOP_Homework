using System;
using System.Threading.Tasks;

namespace Timer
{
    public class Tester
    {
        static void Main()
        {
            //Print current time milliseconds with 2 seconds delay
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
