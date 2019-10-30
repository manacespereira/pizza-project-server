using System;
using System.Collections.Generic;
using PizzaProject.Domain.Core;

namespace PizzaProject.Domain.Entities
{
    public class Flavor : Entity
    {
        public Flavor(string name, int adicionalTime)
        {
            Name = name;
            AdicionalTime = adicionalTime;
        }

        protected Flavor() { }

        public string Name { get; set; }
        public int AdicionalTime { get; set; }
        public IEnumerable<Pizza> Pizzas { get; set; }
    }
}
