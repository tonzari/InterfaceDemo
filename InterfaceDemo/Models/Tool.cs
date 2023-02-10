using InterfaceDemo.Interfaces;

namespace InterfaceDemo.Models
{
    class Tool : ICollectable
    {
        public Player Owner { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }

        public float Durability { get; set; } = 1.0f;

        public float UseDamage { get; set; } = 0.05f;

        public string UseMessage => $"{Owner.PlayerName} used {ItemName}";

        public string GetInfo()
        {
            return $"{ItemName}, Quantity: {Quantity}, Durability: {Durability}";
        }

        public void Use()
        {
            if (Quantity > 0)
            {
                UseTool();
            }
        }

        private void UseTool()
        {
            Durability -= UseDamage;

            if (Durability < 0) Quantity--;

            Owner.PlayerActionLog.Add(UseMessage);

            if (Quantity <= 0) Owner.Inventory.Remove(this);
        }
    }
}
