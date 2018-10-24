using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject s = new ConcreteSubject();
            IObserver ob = new ConcreteObserver(s);
            s.Attach(ob);
            
            s.SetState("New State");

            s.Notify();

            Console.WriteLine();
        }
    }
}
