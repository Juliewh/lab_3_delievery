using System;

namespace FoodDelivery.State
{
    public class CompletedState : IOrderState
    {
        public CompletedState(object order) { }

        public void Advance()
        {
   
            Console.WriteLine("Order already completed.");
        }

        public void Cancel()
        {
            Console.WriteLine("Cannot cancel a completed order.");
        }
    }
}
