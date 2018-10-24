using System;

namespace Decorator
{
    public class SpecialOffer : VehicleDecorator
    {

        public SpecialOffer(IVehicle vehicle) : base(vehicle)
        {

        }

        public int Discount { get; set; }

        public string Offer { get; set; }
        public new double Price
        {
            get
            {
                double price = base.Price;
                int percentage = 100 - Discount;
                return Math.Round((price * percentage) / 100, 2);
            }
        }
    }
}
