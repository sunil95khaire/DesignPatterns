﻿namespace AbstractFactoryMethod
{
    // Added comment
    public class VehicleClient
    {
        IBike bike;
        IScooter scooter;

        public VehicleClient(IVehicleFactory factory, string type)
        {
            bike = factory.GetBike(type);
            scooter = factory.GetScooter(type);
        }

        public string GetBikeName()
        {
            return bike.Name();
        }

        public string GetScooterName()
        {
            return scooter.Name();
        }
    }
}
