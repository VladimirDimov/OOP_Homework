using System;
class EventsExercise
{
    delegate void MyEventHandler(string input);

    class Publisher
    {
        public event MyEventHandler Cycle;

        protected virtual void OnCycle(string input)
        {
            if (this.Cycle != null)
                Cycle(input);
        }
        int time;
        public Publisher(int seconds)
        {
            time = seconds;
        }

        public void StartCycle(string input)
        {
            
            while(Console.KeyAvailable==false)
            {
                OnCycle(input);
                System.Threading.Thread.Sleep(time * 1000);
            }
            Console.ReadKey();
        }
    }

    class Subscriber
    {
        public Subscriber(Publisher publisher)
        {
            publisher.Cycle += SubscriberMethod; 
        }
        public void SubscriberMethod(string input)
        {
            Console.WriteLine("Instance Subcriber: {0}", input);
        }
        public void DetachFrom(Publisher publisher)
        {
            publisher.Cycle -= SubscriberMethod;
        }
    }

    static class StaticSubscriber
    {
        public static void SubscribeTo(Publisher publisher)
        {
            publisher.Cycle += StaticSubscriberMethod;
        }
        static void StaticSubscriberMethod(string input)
        {
            Console.WriteLine("Static Subscriber: {0}", input);
        }
        public static void DetachFrom(Publisher publisher)
        {
            publisher.Cycle -= StaticSubscriberMethod;
        }
    }
    static void Main(string[] args)
    {
        Publisher myPublisher = new Publisher(7);
        Subscriber mySubscriber = new Subscriber(myPublisher);
        StaticSubscriber.SubscribeTo(myPublisher);

        myPublisher.StartCycle("Cycle Started. Press any key to stop it.");
        mySubscriber.DetachFrom(myPublisher);

        myPublisher.StartCycle("Cycle Started Again!. Press any key to stop it.");
        StaticSubscriber.DetachFrom(myPublisher);        

        Console.WriteLine("All is well that ends well.");
    }
}
