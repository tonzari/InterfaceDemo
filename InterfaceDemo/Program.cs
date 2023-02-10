using InterfaceDemo.Interfaces;
using InterfaceDemo.Models;

Console.Write("Welcome to the Player Inventory / C# Interfaces demo! Enter Player name: ");
string userName = Console.ReadLine();

Player player = new Player(userName);

do
{
    Console.Clear();

    Console.WriteLine("\nPlayer inventory - - - - - - - - - - - - - - - -\n");          // Print out full player Inventory

    for (int i = 0; i < player.Inventory.Count; i++)
    {
        Console.Write(i + ". " + player.Inventory[i].GetInfo());
       
        if (player.Inventory[i] is IEdible) Console.Write(", (edible!)");               // Add a little message to notify player that the inventory item is edible (just to demonstrate C# 'variable is Type' syntax)

        Console.WriteLine();
    }

    Console.WriteLine("\nAction Log - - - - - - - - - - - - - - - - - - - -\n");        // Print out entire Player Action history

    foreach (string playerAction in player.PlayerActionLog)
    {
        Console.WriteLine(playerAction);
    }

    Console.WriteLine("\nSelect an item in your inventory by number: ");
    string userInput = Console.ReadLine();
    int userNum = int.Parse(userInput);

    if (player.Inventory.Count > 0 && userNum < player.Inventory.Count )                // Only allow a number within the bounds of the Inventory list
    {
        var itemSelected = player.Inventory[userNum];

        itemSelected.Use();
    }

} while (true);

