namespace FoodDelivery.Strategy
{
    public class FastDeliveryPriceStrategy : IPriceStrategy
    {
        private readonly IPriceStrategy _inner;
        private readonly decimal _fastFee;
        public FastDeliveryPriceStrategy(IPriceStrategy inner, decimal fastFee)
        {
            _inner = inner;
            _fastFee = fastFee;
        }

        public decimal Calculate(decimal baseAmount)
        {
            var amount = _inner.Calculate(baseAmount);
            return amount + _fastFee;
        }
    }
}
