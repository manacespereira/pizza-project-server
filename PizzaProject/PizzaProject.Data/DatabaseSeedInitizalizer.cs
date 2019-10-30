using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PizzaProject.Domain.Entities;

namespace PizzaProject.Data
{
    public static class DatabaseSeedInitizalizer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PizzaSize>().HasData(new List<PizzaSize> {
                new PizzaSize("Pizza pequena", 20.00, 15),
                new PizzaSize("Pizza média", 30.00, 20),
                new PizzaSize("Pizza grande", 40.00, 25)
            });

            modelBuilder.Entity<Flavor>().HasData(new List<Flavor> {
                new Flavor("Calabresa", 0),
                new Flavor("Marguerita", 0),
                new Flavor("Portuguesa", 5),
            });

            modelBuilder.Entity<Customization>().HasData(new List<Customization> {
                new Customization("Bacon Extra", 3.00, 0),
                new Customization("Sem Cebola", 0.00, 0),
                new Customization("Borda Recheada", 5.00, 5)
            });
        }
    }
}
