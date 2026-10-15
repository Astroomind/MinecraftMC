using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MinecraftCM.Items;

namespace MinecraftCM.Chests
{
    internal class Chest
    {
        public String Name { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
