namespace Decorator
{
    public class HondaCity : IVehicle
    {
        public string Make { get { return "Honda"; } }

        public string Model { get { return "City"; } }

        public double Price { get { return 1000000; } }
    }
}
