using Microsoft.EntityFrameworkCore;
using MinecraftCM;
using MinecraftCM.Chests;
using MinecraftCM.Items;

using var db = new AppDbContext();
db.Database.Migrate();

Console.WriteLine("""
    Would you like to add a chest or view your saved chests?
     Press 1 to add a chest.
     Press 2 to view your saved chests.
    """);
int userChoice = Convert.ToInt32(Console.ReadLine());

if (userChoice == 1)
{
    Console.Write("What would you like to call your chest? ");
    var chest = new Chest { Name = Console.ReadLine() ?? "" };

    while (true)
    {
        Console.Write("Item name (Leave blank to finish): ");
        string? itemName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(itemName)) break;

        Console.Write("How many? ");
        if (!int.TryParse(Console.ReadLine(), out int quantity))
        {
            Console.WriteLine("That's not a number, try again");
            continue;
        }

        chest.AddItem(new Item { Name = itemName, Quantity = quantity });
    }

    db.Chests.Add(chest);
    db.SaveChanges();
    Console.WriteLine("Chest Saved!");
}
else if (userChoice == 2)
{
    var allChests = db.Chests.Include(c => c.Items).ToList();
    foreach (var c in allChests)
    {
        c.ShowContents();
    }
}