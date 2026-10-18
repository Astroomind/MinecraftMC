using MinecraftCM.Items;
using MinecraftCM.Chests;


Chest storage = new Chest { Name = Console.ReadLine() };


storage.AddItem(new Item { Name = "Diamond", Quantity = 100 });
storage.AddItem(new Item { Name = "Coal", Quantity = 10 });

storage.ShowContents();