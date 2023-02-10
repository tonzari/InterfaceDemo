using InterfaceDemo.Interfaces;

namespace InterfaceDemo.Models
{
    class Fruit : Food, IEdible
    {

        public override Player Owner { get; set; }

        public override string UseMessage 
        { 
            get { return $"{Owner.PlayerName} ate {ItemName}"; }
        }

        public void Eat()
        {
            Quantity--;
            Owner.PlayerActionLog.Add(UseMessage);

            if (Quantity <= 0) Owner.Inventory.Remove(this);
        }

        public override string GetInfo()
        {
            return $"{ItemName}, Quantity: {Quantity}, Energy: {EnergyProvided}";
        }

        public override void Use()
        {
            if (Quantity > 0)
            {
                Eat();
            }
        }
    }

}
