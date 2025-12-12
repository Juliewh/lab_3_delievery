using System;

namespace FoodDelivery.Utils
{
    public sealed class IdGenerator
    {
        private static readonly Lazy<IdGenerator> _instance = new Lazy<IdGenerator>(() => new IdGenerator());
        public static IdGenerator Instance => _instance.Value;
        private IdGenerator() { }

        public Guid NewId() => Guid.NewGuid();
    }
}
