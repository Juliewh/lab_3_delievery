namespace FoodDelivery.Observer
{
    public interface IOrderObserver
    {
        void OnOrderUpdated(string message);
    }
}
