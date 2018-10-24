using System;

namespace State
{
    public class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Handled called from concrete state B");
            context.State = new ConcreteStateB();
        }
    }
}
