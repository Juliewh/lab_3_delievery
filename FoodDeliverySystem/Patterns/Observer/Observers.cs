using System;

namespace FoodDeliverySystem
{
    public interface IObserver
    {
        void Update(string status);
    }

    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    public class Customer : IObserver
    {
        public string Name { get; private set; }

        public Customer(string name)
        {
            Name = name;
        }

        public void Update(string status)
        {
            Console.WriteLine($" >> [SMS для {Name}]: Статус заказа сменился на: '{status}'");
        }
    }
}
