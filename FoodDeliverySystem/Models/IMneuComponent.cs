using System.Collections.Generic;

namespace FoodDelivery.Models
{
    public interface IMenuComponent
    {
        string Name { get; }
        decimal Price { get; } 
        void Add(IMenuComponent component);
        void Remove(IMenuComponent component);
        IEnumerable<IMenuComponent> GetChildren();
    }
}
