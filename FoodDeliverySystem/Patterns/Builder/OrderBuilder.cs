namespace FoodDeliverySystem
{
    public interface IOrderBuilder
    {
        void Reset();
        void SetAddress(string address);
        void AddDish(string name, decimal price);
        void SetPricingType();
        void SetCustomer(string name);
        Order GetProduct();
    }

    public class StandardOrderBuilder : IOrderBuilder
    {
        private Order _order;

        public StandardOrderBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _order = new Order();
        }

        public void SetAddress(string address)
        {
            _order.DeliveryAddress = address;
        }

        public void AddDish(string name, decimal price)
        {
            _order.AddDish(new Dish(name, price));
        }

        public void SetPricingType()
        {
            _order.SetPricingStrategy(new StandardPricingStrategy());
        }

        public void SetCustomer(string name)
        {
            _order.Attach(new Customer(name));
        }

        public Order GetProduct()
        {
            Order result = _order;
            Reset();
            return result;
        }
    }

    public class VipOrderBuilder : IOrderBuilder
    {
        private Order _order;

        public VipOrderBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _order = new Order();
        }

        public void SetAddress(string address)
        {
            _order.DeliveryAddress = address + " (VIP Вход)";
        }

        public void AddDish(string name, decimal price)
        {
            _order.AddDish(new Dish(name, price));
        }

        public void SetPricingType()
        {
            _order.SetPricingStrategy(new VipPricingStrategy());
        }

        public void SetCustomer(string name)
        {
            _order.Attach(new Customer(name + " [VIP]"));
        }

        public Order GetProduct()
        {
            Order result = _order;
            Reset();
            return result;
        }
    }
}
