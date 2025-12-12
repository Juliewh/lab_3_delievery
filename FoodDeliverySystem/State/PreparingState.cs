using System;
using FoodDelivery.Models;

namespace FoodDelivery.State
{
    public class PreparingState : IOrderState
    {
        private readonly Order _order;
        public PreparingState(Order order) => _order = order;

        public void Advance()
        {
            _order.SetState(new DeliveringState(_order));
        }

        public void Cancel()
        {
            Console.WriteLine($"Order {_order.Id} canceled while preparing.");
            _order.SetState(new CompletedState(_order));
        }
    }
}
