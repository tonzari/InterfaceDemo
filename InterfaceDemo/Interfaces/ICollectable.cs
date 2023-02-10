using InterfaceDemo.Models;

namespace InterfaceDemo.Interfaces
{
    interface ICollectable
    {
        Player Owner { get; set; }
        string ItemName { get; set; }
        string UseMessage { get; }
        int Quantity { get; set; }
        string GetInfo();
        void Use();
    }
}
