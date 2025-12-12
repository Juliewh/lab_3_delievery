using FoodDelivery.Utils;

namespace FoodDelivery.Strategy
{
    public class TaxDecorator : PriceDecorator
    {
        private readonly decimal _taxPercent;
        public TaxDecorator(IPriceStrategy inner, decimal taxPercent) : base(inner)
        {
            _taxPercent = taxPercent;
        }

        public override decimal Calculate(decimal baseAmount)
        {
            var baseNoTax = _inner is BasePriceStrategy ? baseAmount : _inner.Calculate(baseAmount);
            var tax = baseNoTax * _taxPercent;
            return baseNoTax + tax;
        }
    }
}
