namespace FoodDelivery.Strategy
{
    public abstract class PriceDecorator : IPriceStrategy
    {
        protected readonly IPriceStrategy _inner;
        protected PriceDecorator(IPriceStrategy inner) => _inner = inner;

        public virtual decimal Calculate(decimal baseAmount) => _inner.Calculate(baseAmount);
    }
}
