using System;
using Microsoft.EntityFrameworkCore;
using PizzaProject.Data.EntityConfigurations;
using PizzaProject.Domain.Entities;

namespace PizzaProject.Data
{
    public class PizzaProjectContext : DbContext
    {
        public string ConnectionString { get => "Data Source=pizzaria.db"; }

        public PizzaProjectContext() { }

        public PizzaProjectContext(DbContextOptions<PizzaProjectContext> options) : base(options) { }


        public DbSet<Customization> Customizations { get; set; }
        public DbSet<Flavor> Flavors { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<PizzaCustomization> PizzaCustomizations { get; set; }
        public DbSet<PizzaSize> PizzaSizes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomizationConfiguration());
            modelBuilder.ApplyConfiguration(new FlavorConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new PizzaConfiguration());
            modelBuilder.ApplyConfiguration(new PizzaCustomizationConfiguration());
            modelBuilder.ApplyConfiguration(new PizzaSizeConfiguration());
            DatabaseSeedInitizalizer.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
