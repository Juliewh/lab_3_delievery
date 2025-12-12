using FoodDelivery.Utils;

namespace FoodDelivery.Strategy
{
    public class BasePriceStrategy : IPriceStrategy
    {
        public virtual decimal Calculate(decimal baseAmount)
        {
            var tax = baseAmount * Configuration.Instance.TaxPercent;
            return baseAmount + tax;
        }
    }
}
