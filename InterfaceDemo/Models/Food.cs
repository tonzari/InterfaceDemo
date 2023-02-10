using InterfaceDemo.Interfaces;

namespace InterfaceDemo.Models
{
    abstract class Food : ICollectable
    {
        public abstract Player Owner { get; set; }
        public int EnergyProvided { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public abstract string UseMessage { get; }

        public abstract string GetInfo();

        public virtual void Use() { }
    }
}
