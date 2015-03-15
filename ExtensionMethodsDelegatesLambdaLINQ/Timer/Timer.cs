namespace Timer
{
    using System;
    using System.Threading;

    public delegate void deleg();

    public class Timer
    {
        private deleg method;

        public Timer(deleg a)
        {
            method = a;
        }

        public void DoPeriodically(int delay)
        {
            while (true)
            {
                method();
                Thread.Sleep(delay*1000);
            }
        }
    }
}
