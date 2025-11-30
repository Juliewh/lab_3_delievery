using System;

namespace FoodDeliverySystem
{
    public abstract class OrderState
    {
        protected Order _order;

        public void SetContext(Order order)
        {
            _order = order;
        }

        public abstract void Process();
        public abstract string GetStatusName();
    }

    public class CreatedState : OrderState
    {
        public override void Process()
        {
            Console.WriteLine("--- [Кухня] Начинаем готовить заказ... ---");
            _order.TransitionTo(new CookingState());
        }

        public override string GetStatusName() => "Принят / В очереди";
    }

    public class CookingState : OrderState
    {
        public override void Process()
        {
            Console.WriteLine("--- [Кухня] Всё готово. Передаем курьеру... ---");
            _order.TransitionTo(new DeliveryState());
        }
        public override string GetStatusName() => "Готовится";
    }

    public class DeliveryState : OrderState
    {
        public override void Process()
        {
            Console.WriteLine("--- [Курьер] Приехал и отдал заказ. ---");
            _order.TransitionTo(new CompletedState());
        }
        public override string GetStatusName() => "В пути";
    }

    public class CompletedState : OrderState
    {
        public override void Process()
        {
            Console.WriteLine("--- Заказ уже закрыт. ---");
        }
        public override string GetStatusName() => "Выполнен";
    }
}
