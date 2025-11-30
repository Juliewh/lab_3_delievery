using System;

namespace FoodDeliverySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Система Доставки Еды (Паттерны) ===\n");

            Console.WriteLine("1. Создаем ОБЫЧНЫЙ заказ...");

            OrderFactory standardFactory = new StandardOrderFactory();
            var builder1 = standardFactory.CreateBuilder();

            builder1.SetCustomer("Алексей");
            builder1.SetAddress("ул. Пушкина, д. 10");
            builder1.SetPricingType();
            builder1.AddDish("Пицца Пепперони", 500);
            builder1.AddDish("Кола", 100);

            Order order1 = builder1.GetProduct();
            Console.WriteLine($"Итого к оплате (с доставкой): {order1.GetTotalPrice()} руб.");

            order1.NextStep(); 
            order1.NextStep(); 
            order1.NextStep(); 

            Console.WriteLine("\n-----------------------------------\n");

            Console.WriteLine("2. Создаем VIP заказ...");

            OrderFactory vipFactory = new VipOrderFactory();
            var builder2 = vipFactory.CreateBuilder();

            builder2.SetCustomer("Мария Ивановна");
            builder2.SetAddress("Москва-Сити");
            builder2.SetPricingType();
            builder2.AddDish("Лобстер", 2500);
            builder2.AddDish("Вино", 1500);

            Order order2 = builder2.GetProduct();
            Console.WriteLine($"Итого к оплате (VIP скидка): {order2.GetTotalPrice()} руб.");

            order2.NextStep(); 
            order2.NextStep(); 

            Console.ReadKey();
        }
    }
}
