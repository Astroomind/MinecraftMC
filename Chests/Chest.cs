using MinecraftCM.Items;

namespace MinecraftCM.Chests
{
    public class Chest
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Item> Items { get; set; } = new List<Item>();

        public int ChestId { get; set; }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void ShowContents()
        {
            Console.WriteLine($"The chest is called {Name}");

            foreach (Item item in Items)
            {
                Console.WriteLine($"{item.Name} x {item.Quantity}");
            }
        }
    }
}
