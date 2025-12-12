using System;
using System.Collections.Generic;
using System.Linq;
using FoodDelivery.Observer;
using FoodDelivery.State;
using FoodDelivery.Strategy;

namespace FoodDelivery.Models
{
    public class Order : OrderSubject
    {
        public Guid Id { get; }
        public string CustomerName { get; }
        public string Address { get; }
        public IList<OrderItem> Items { get; }
        public string SpecialRequests { get; }
        private IOrderState _state;
        public IPriceStrategy PriceStrategy { get; set; }

        public Order(Guid id, string customerName, string address, IList<OrderItem> items, string specialRequests, IPriceStrategy priceStrategy)
        {
            Id = id;
            CustomerName = customerName;
            Address = address;
            Items = items;
            SpecialRequests = specialRequests;
            PriceStrategy = priceStrategy;
            _state = new PreparingState(this);
        }

        public string StateName => _state.GetType().Name;

        public void SetState(IOrderState state)
        {
            _state = state;
            NotifyObservers($"StateChanged:{StateName}");
        }

        public void AdvanceState()
        {
            _state.Advance();
        }

        public void Cancel()
        {
            _state.Cancel();
        }

        public decimal CalculatePrice()
        {
            var baseAmount = Items.Sum(i => i.GetTotal());
            return PriceStrategy.Calculate(baseAmount);
        }
    }
}
