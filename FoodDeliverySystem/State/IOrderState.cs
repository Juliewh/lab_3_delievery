namespace FoodDelivery.State
{
    public interface IOrderState
    {
        void Advance(); 
        void Cancel(); 
    }
}
