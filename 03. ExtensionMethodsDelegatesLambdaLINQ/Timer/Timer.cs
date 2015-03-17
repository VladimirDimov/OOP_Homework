namespace Timer
{
    using System;
    using System.Threading;


    public class Timer
    {
        public delegate void InputMethod();
        private int timeIntervaInSeconds;

        public InputMethod Method { get; set; }

        public int TimeIntervaInSeconds
        {
            get { return this.timeIntervaInSeconds; }
            set { this.timeIntervaInSeconds = value; }
        }

        public void Execute()
        {
            while (true)
            {
                this.Method();
                Thread.Sleep(this.TimeIntervaInSeconds*1000);
            }
        }

    }
}
