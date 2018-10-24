using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory vf = new ConcreteVehicleFactory();

            IFactory bike = vf.GetVehicle("B");
            bike.Drive(100);

            IFactory scooter = vf.GetVehicle("S");
            scooter.Drive(50);

            Console.ReadKey();
        }
    }
}
