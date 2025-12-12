using FoodDelivery.Strategy;
using FoodDelivery.Models;
using System.Collections.Generic;

namespace FoodDelivery.Factories
{
    public abstract class OrderAbstractFactory
    {
        public abstract IPriceStrategy CreatePriceStrategy();
    }
}
