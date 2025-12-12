using System;
using FoodDelivery.Models;
using FoodDelivery.Services;
using FoodDelivery.Commands;

namespace FoodDelivery.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _repo;
        public OrderService(IOrderRepository repo)
        {
            _repo = repo;
        }

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }

        public Order GetOrder(Guid id) => _repo.GetById(id);
    }
}
