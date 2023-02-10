using InterfaceDemo.Interfaces;

namespace InterfaceDemo.Models
{
    class Material : ICollectable
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public Player Owner { get; set; }

        public string UseMessage => $"{Owner.PlayerName} built something with {ItemName}";

        public void Build()
        {
            Quantity--;
            Owner.PlayerActionLog.Add(UseMessage);

            if (Quantity <= 0) Owner.Inventory.Remove(this);
        }

        public void Use()
        {
            if (Quantity > 0)
            {
                Build();
            }

        }

        public string GetInfo()
        {
            return $"{ItemName}, Quantity: {Quantity}";
        }
    }

}
