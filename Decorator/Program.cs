using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic vehicle
            var car = new HondaCity();

            Console.WriteLine("Honda City base price are : {0}", car.Price);

            // Special offer
            var offer = new SpecialOffer(car)
            {
                Discount = 25,
                Offer = "25 % discount"
            };

            Console.WriteLine("{1} @ Diwali Special Offer and price are : {0} ", offer.Price, offer.Offer);

            Console.ReadKey();
        }
    }
}
