using System;
using System.Collections.Generic;
using PizzaProject.Domain.Core;

namespace PizzaProject.Domain.Entities
{
    public class Customization : Entity
    {
        public Customization(string name, double price, int adicionalTime)
        {
            Name = name;
            Price = price;
            AdicionalTime = adicionalTime;
        }

        protected Customization() { }

        public string Name { get; set; }
        public double Price { get; set; }
        public int AdicionalTime { get; set; }
        public IEnumerable<PizzaCustomization> PizzaCustomizations { get; set; }
    }
}
