namespace AbstractFactoryMethod
{
    public interface IVehicleFactory
    {
        IBike GetBike(string bike);
        IScooter GetScooter(string scooter);
    }
}
