using System;

namespace AbstractFactoryMethod
{
    public class HeroFactory : IVehicleFactory
    {
        public IBike GetBike(string bike)
        {
            switch (bike)
            {
                case "Sports":
                    return new SportsBike();
                case "Regular":
                    return new RegularBike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", bike));
            }
        }

        public IScooter GetScooter(string scooter)
        {
            switch (scooter)
            {
                case "Sports":
                    return new Scooty();
                case "Regular":
                    return new RegularScooty();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", scooter));
            }
        }
    }
}
