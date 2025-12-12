namespace FoodDelivery.Strategy
{
    public class DiscountDecorator : PriceDecorator
    {
        private readonly decimal _discountPercent;
        public DiscountDecorator(IPriceStrategy inner, decimal discountPercent) : base(inner)
        {
            _discountPercent = discountPercent;
        }

        public override decimal Calculate(decimal baseAmount)
        {
            var amount = base.Calculate(baseAmount);
            var discount = amount * _discountPercent;
            return amount - discount;
        }
    }
}
