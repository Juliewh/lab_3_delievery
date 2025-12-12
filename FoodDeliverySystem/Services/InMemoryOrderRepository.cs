using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using FoodDelivery.Models;
using System.Linq;

namespace FoodDelivery.Services
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        private readonly ConcurrentDictionary<Guid, Order> _store = new ConcurrentDictionary<Guid, Order>();

        public void Add(Order order)
        {
            _store[order.Id] = order;
        }

        public Order GetById(Guid id)
        {
            _store.TryGetValue(id, out var order);
            return order;
        }

        public IEnumerable<Order> GetAll() => _store.Values.ToList();

        public void Update(Order order)
        {
            _store[order.Id] = order;
        }
    }
}
