using FoodDelivery.Strategy;

namespace FoodDelivery.Factories
{
    public class StandardOrderFactory : OrderAbstractFactory
    {
        public override IPriceStrategy CreatePriceStrategy()
        {
            return new BasePriceStrategy();
        }
    }
}
