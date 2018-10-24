using System;

namespace State
{
    public class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Handled called from concrete state A");
            context.State = new ConcreteStateA();
        }
    }
}
