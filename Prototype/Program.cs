using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var dev = new Developer
            {
                Name = "Rahul",
                Address = "Team Leader"
            };

            var devCopy = (Developer)dev.Clone();
            devCopy.Name = "Arif"; //Not mention address, it will copy above

            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devCopy.GetDetails());

            var Tester = new Tester
            {
                Name = "Monu",
                Address = "Tester"
            };

            var TesterCopy = (Tester)Tester.Clone();
            TesterCopy.Name = "Sahil"; //Not mention address, it will copy above

            Console.WriteLine(Tester.GetDetails());
            Console.WriteLine(TesterCopy.GetDetails());

            Console.ReadKey();
        }
    }
}
