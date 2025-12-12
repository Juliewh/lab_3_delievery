using System;

namespace FoodDelivery.Observer
{
    public class CustomerNotifier : IOrderObserver
    {
        private readonly string _customerName;
        public CustomerNotifier(string customerName) => _customerName = customerName;

        public void OnOrderUpdated(string message)
        {
            Console.WriteLine($"[Customer {_customerName}] Notification: {message}");
        }
    }
}
