using System;

namespace FoodDelivery.Observer
{
    public class DeliveryNotifier : IOrderObserver
    {
        public void OnOrderUpdated(string message)
        {
            Console.WriteLine($"[DeliveryTeam] Notification: {message}");
        }
    }
}
