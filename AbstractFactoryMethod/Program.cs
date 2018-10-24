using System;

namespace AbstractFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory factory = new HondaFactory();

            VehicleClient client = new VehicleClient(factory, "Regular");
            string bikeName = client.GetBikeName();
            string scooterName = client.GetScooterName();

            client = new VehicleClient(factory, "Sports");
            bikeName = client.GetBikeName();
            scooterName = client.GetScooterName();

            factory = new HeroFactory();

            client = new VehicleClient(factory, "Regular");
            bikeName = client.GetBikeName();
            scooterName = client.GetScooterName();

            client = new VehicleClient(factory, "Sports");
            bikeName = client.GetBikeName();
            scooterName = client.GetScooterName();

            Console.ReadKey();
        }
    }
}
