namespace FoodDelivery.Utils
{
    public sealed class Configuration
    {
        private static readonly Lazy<Configuration> _instance = new Lazy<Configuration>(() => new Configuration());
        public static Configuration Instance => _instance.Value;
        private Configuration()
        {
            FastDeliveryFee = 5.0m;
            TaxPercent = 0.10m;
        }
        public decimal FastDeliveryFee { get; set; }
        public decimal TaxPercent { get; set; }
    }
}
