using System.Collections.Generic;

namespace FoodDelivery.Observer
{
    public abstract class OrderSubject
    {
        private readonly List<IOrderObserver> _observers = new List<IOrderObserver>();
        public void Attach(IOrderObserver observer) => _observers.Add(observer);
        public void Detach(IOrderObserver observer) => _observers.Remove(observer);
        public void NotifyObservers(string message)
        {
            foreach (var o in _observers)
                o.OnOrderUpdated(message);
        }
    }
}
