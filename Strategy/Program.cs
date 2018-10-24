using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            INetPayable local = new LocalPayable();
            INetPayable inter = new InterStatePayable();

            Invoice s = new Invoice(local);
            Console.WriteLine(s.Calculate());

            s = new Invoice(inter);
            Console.WriteLine(s.Calculate());

            Console.ReadKey();
        }
    }
}
