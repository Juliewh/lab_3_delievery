namespace FoodDeliverySystem
{
    public abstract class OrderFactory
    {
        public abstract IOrderBuilder CreateBuilder();
    }

    public class StandardOrderFactory : OrderFactory
    {
        public override IOrderBuilder CreateBuilder()
        {
            return new StandardOrderBuilder();
        }
    }

    public class VipOrderFactory : OrderFactory
    {
        public override IOrderBuilder CreateBuilder()
        {
            return new VipOrderBuilder();
        }
    }
}
