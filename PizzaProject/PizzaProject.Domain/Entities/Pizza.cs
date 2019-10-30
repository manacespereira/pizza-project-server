using System;
using System.Collections.Generic;
using PizzaProject.Domain.Core;

namespace PizzaProject.Domain.Entities
{
    public class Pizza : Entity
    {
        public Pizza(PizzaSize size, Flavor flavor, IEnumerable<PizzaCustomization> pizzaCustomizations)
        {
            Size = size;
            Flavor = flavor;
            PizzaCustomizations = pizzaCustomizations ?? new List<PizzaCustomization>();
        }

        protected Pizza () { }

        public PizzaSize Size { get; set; }
        public Flavor Flavor { get; set; }
        public IEnumerable<PizzaCustomization> PizzaCustomizations { get; set; }
    }
}
