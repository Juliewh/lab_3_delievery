using FoodDelivery.Models;

namespace FoodDelivery.Factories
{
    public interface IMenuFactory
    {
        MenuItem CreateMenuItem(string name, decimal price);
    }
}
