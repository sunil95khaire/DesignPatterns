using System;

namespace Strategy
{
    public class LocalPayable : INetPayable
    {
        public double CalculateTotal()
        {
            return 100;
        }
    }
}
