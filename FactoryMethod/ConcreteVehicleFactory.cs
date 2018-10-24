using System;

namespace FactoryMethod
{
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string Vehicle)
        {
            switch (Vehicle)
            {
                case "B":
                    return new Bike();                    
                case "S":
                    return new Scooter();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
            }
        }
    }
}
