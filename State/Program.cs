using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            IState a = new ConcreteStateA();
            IState b = new ConcreteStateB();

            Context c = new Context(a);
            c.Request();

            c = new Context(b);
            c.Request();

            Console.ReadKey();
        }
    }
}
