using FoodDelivery.Models;

namespace FoodDelivery.State
{
    public class DeliveringState : IOrderState
    {
        private readonly Order _order;
        public DeliveringState(Order order) => _order = order;

        public void Advance()
        {
            _order.SetState(new CompletedState(_order));
        }

        public void Cancel()
        {
            _order.SetState(new CompletedState(_order));
        }
    }
}
