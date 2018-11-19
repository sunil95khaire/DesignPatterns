using System;

namespace Adapter
{
    // Adapter Design Pattern
    class Program
    {
        static void Main(string[] args)
        {
            ITraget target = new EmployeeAdapter();
            var tpbs = new ThirdPartyBillingSystem(target);
            tpbs.ShowEmployeeList();
            Console.ReadKey();
        }
    }
}
