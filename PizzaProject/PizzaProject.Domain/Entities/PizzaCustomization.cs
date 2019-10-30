using System;
using PizzaProject.Domain.Core;

namespace PizzaProject.Domain.Entities
{
    public class PizzaCustomization : Entity
    {
        public Pizza Pizza { get; set; }
        public Customization Customization { get; set; }
    }
}
