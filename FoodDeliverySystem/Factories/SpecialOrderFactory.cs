using FoodDelivery.Strategy;
using FoodDelivery.Utils;

namespace FoodDelivery.Factories
{
    public class SpecialOrderFactory : OrderAbstractFactory
    {
        public override IPriceStrategy CreatePriceStrategy()
        {
            var baseStrat = new BasePriceStrategy();
            var withFast = new FastDeliveryPriceStrategy(baseStrat, Configuration.Instance.FastDeliveryFee);
            return withFast;
        }
    }
}
