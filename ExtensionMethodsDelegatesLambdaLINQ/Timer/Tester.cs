using System;
using System.Threading.Tasks;

namespace Timer
{
    public class Tester
    {
        static void Main()
        {
            //Print current time milliseconds with 2 seconds delay
            Timer timer = new Timer(new deleg(GetCurrentTimeMilliseconds));
            timer.DoPeriodically(2);           
        }

        static void GetCurrentTimeMilliseconds()
        {
            Console.WriteLine(DateTime.Now.Millisecond);
        }

    }
}
