namespace Strategy
{
    public class Invoice
    {
        INetPayable _calc;
        double _total;

        public Invoice(INetPayable calc)
        {
            _calc = calc;
        }

        public INetPayable NetPayableAmount { get; set; }

        public double GrossAmount { get; set; }

        public double NetAmount { get; set; }

        public double Calculate()
        {
            return _calc.CalculateTotal();            
        }
    }
}
