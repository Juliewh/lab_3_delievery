using System;
using FoodDelivery.Models;
using System.Collections.Generic;

namespace FoodDelivery.Services
{
    public interface IOrderRepository
    {
        void Add(Order order);
        Order GetById(Guid id);
        IEnumerable<Order> GetAll();
        void Update(Order order);
    }
}

