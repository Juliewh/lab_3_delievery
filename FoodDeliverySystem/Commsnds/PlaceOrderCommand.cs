using FoodDelivery.Models;
using FoodDelivery.Services;

namespace FoodDelivery.Commands
{
    public class PlaceOrderCommand : ICommand
    {
        private readonly Order _order;
        private readonly IOrderRepository _repo;

        public PlaceOrderCommand(Order order, IOrderRepository repo)
        {
            _order = order;
            _repo = repo;
        }

        public void Execute()
        {
            _repo.Add(_order);
            _order.NotifyObservers($"OrderPlaced:{_order.Id}");
        }
    }
}
