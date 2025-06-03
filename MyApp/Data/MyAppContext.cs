using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Data
{
    public class MyAppContext : DbContext
    {

        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options) { }


        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1, Name="VIT"},
                new Category { Id = 2, Name = "IIT Delhi" },
                new Category { Id = 3, Name = "SRM" },
                new Category { Id = 4, Name = "Amity" },
                new Category { Id = 5, Name = "DTU" }
                
            );

            

            base.OnModelCreating(modelBuilder);

        }

        public DbSet <Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
