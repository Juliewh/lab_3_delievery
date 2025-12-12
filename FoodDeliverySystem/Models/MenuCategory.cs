using System.Collections.Generic;
using System.Linq;

namespace FoodDelivery.Models
{
    public class MenuCategory : IMenuComponent
    {
        private readonly List<IMenuComponent> _children = new List<IMenuComponent>();
        public string Name { get; }
        public decimal Price => 0m; 

        public MenuCategory(string name)
        {
            Name = name;
        }

        public void Add(IMenuComponent component)
        {
            _children.Add(component);
        }

        public void Remove(IMenuComponent component)
        {
            _children.Remove(component);
        }

        public IEnumerable<IMenuComponent> GetChildren() => _children.ToList();
    }
}
