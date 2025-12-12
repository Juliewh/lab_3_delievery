namespace FoodDelivery.Strategy
{
    public interface IPriceStrategy
    {
        decimal Calculate(decimal baseAmount);
    }
}
