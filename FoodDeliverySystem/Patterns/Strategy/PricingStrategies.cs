using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem
{
    public class StandardPricingStrategy : IPricingStrategy
    {
        public decimal CalculateCost(decimal basePrice)
        {
            return basePrice + 300.0m; 
        }
    }

    public class VipPricingStrategy : IPricingStrategy
    {
        public decimal CalculateCost(decimal basePrice)
        {
            return basePrice * 0.9m;
        }
    }
}
