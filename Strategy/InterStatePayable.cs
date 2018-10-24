namespace Strategy
{
    public class InterStatePayable : INetPayable
    {
        public double CalculateTotal()
        {
            return 200;
        }
    }
}
