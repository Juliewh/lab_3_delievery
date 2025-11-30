using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodDeliverySystem
{
    public class Order : ISubject
    {
        private List<Dish> _dishes = new List<Dish>();

        private OrderState _state;

        private IPricingStrategy _pricingStrategy;

        private List<IObserver> _observers = new List<IObserver>();

        public string DeliveryAddress { get; set; }

        public Order()
        {
            TransitionTo(new CreatedState());
        }

        public void AddDish(Dish dish)
        {
            _dishes.Add(dish);
        }

        public void SetPricingStrategy(IPricingStrategy strategy)
        {
            _pricingStrategy = strategy;
        }

        public void TransitionTo(OrderState state)
        {
            _state = state;
            _state.SetContext(this);
            Notify();
        }

        public void NextStep()
        {
            if (_state != null)
                _state.Process();
        }

        public void PrintStatus()
        {
            Console.WriteLine($"Текущий статус: {_state.GetStatusName()}");
        }

        public decimal GetTotalPrice()
        {
            decimal basePrice = _dishes.Sum(d => d.Price);
            if (_pricingStrategy == null) return basePrice;

            return _pricingStrategy.CalculateCost(basePrice);
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            if (_state == null) return;

            foreach (var observer in _observers)
            {
                observer.Update(_state.GetStatusName());
            }
        }
    }
}
