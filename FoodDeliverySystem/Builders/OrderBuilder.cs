using System;
using System.Collections.Generic;
using FoodDelivery.Models;
using FoodDelivery.Factories;
using FoodDelivery.Strategy;
using FoodDelivery.Utils;

namespace FoodDelivery.Builders
{
    public class OrderBuilder
    {
        private Guid _id;
        private string _customerName;
        private string _address;
        private List<OrderItem> _items = new List<OrderItem>();
        private string _specialRequests;
        private IPriceStrategy _priceStrategy;

        public OrderBuilder()
        {
            _id = IdGenerator.Instance.NewId();
        }

        public OrderBuilder WithCustomer(string name)
        {
            _customerName = name;
            return this;
        }

        public OrderBuilder WithAddress(string address)
        {
            _address = address;
            return this;
        }

        public OrderBuilder AddItem(MenuItem item, int qty = 1, string note = null)
        {
            _items.Add(new OrderItem(item, qty, note));
            return this;
        }

        public OrderBuilder WithSpecialRequests(string requests)
        {
            _specialRequests = requests;
            return this;
        }

        public OrderBuilder WithPriceStrategy(IPriceStrategy strategy)
        {
            _priceStrategy = strategy;
            return this;
        }

        public Models.Order Build()
        {
            if (string.IsNullOrWhiteSpace(_customerName))
                throw new ArgumentException("Customer name required");
            if (string.IsNullOrWhiteSpace(_address))
                throw new ArgumentException("Address required");
            if (_items.Count == 0)
                throw new ArgumentException("Order must have at least one item");

            if (_priceStrategy == null)
                _priceStrategy = new BasePriceStrategy();

            return new Models.Order(_id, _customerName, _address, _items, _specialRequests, _priceStrategy);
        }
    }
}
