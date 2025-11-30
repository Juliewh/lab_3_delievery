using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem
{
    public interface IPricingStrategy
    {
        decimal CalculateCost(decimal basePrice);
    }
}
