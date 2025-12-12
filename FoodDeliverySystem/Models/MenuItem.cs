using System.Collections.Generic;

namespace FoodDelivery.Models
{
    public class MenuItem : IMenuComponent
    {
        public string Name { get; }
        public decimal Price { get; }

        public MenuItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public void Add(IMenuComponent component)
        {
            throw new System.NotSupportedException("Cannot add to a MenuItem");
        }

        public void Remove(IMenuComponent component)
        {
            throw new System.NotSupportedException("Cannot remove from a MenuItem");
        }

        public IEnumerable<IMenuComponent> GetChildren()
        {
            yield break;
        }
    }
}
