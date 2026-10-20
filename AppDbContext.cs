using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MinecraftCM.Items;
using MinecraftCM.Chests;
using System.Runtime.InteropServices.Marshalling;

namespace MinecraftCM
{
    public class AppDbContext : DbContext
    {
        public DbSet<Chest> Chests { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=chests.db");

            using var db = new AppDbContext();
            db.Database.Migrate();
        }

    }
}
