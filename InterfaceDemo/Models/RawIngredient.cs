namespace InterfaceDemo.Models
{
    class RawIngredient : Food
    {
        public override Player Owner { get; set; }

        public override string UseMessage => $"{Owner.PlayerName} added {ItemName} to soup";

        public void Cook()
        {
            Owner.PlayerActionLog.Add(UseMessage);
            Quantity--;

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
                Cook();
            }
        }
    }

}
