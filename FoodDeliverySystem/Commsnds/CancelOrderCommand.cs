using FoodDelivery.Services;
using System;

namespace FoodDelivery.Commands
{
    public class CancelOrderCommand : ICommand
    {
        private readonly System.Guid _orderId;
        private readonly IOrderRepository _repo;
        public CancelOrderCommand(System.Guid orderId, IOrderRepository repo)
        {
            _orderId = orderId;
            _repo = repo;
        }

        public void Execute()
        {
            var order = _repo.GetById(_orderId);
            if (order != null)
            {
                order.Cancel();
                _repo.Update(order);
                order.NotifyObservers($"OrderCanceled:{order.Id}");
            }
            else
            {
                Console.WriteLine($"Order {_orderId} not found.");
            }
        }
    }
}
