using System;
using System.Linq;
using PizzaProject.Domain.Core;

namespace PizzaProject.Domain.Entities
{
    public class Order : Entity
    {
        public Order(Pizza pizza)
        {
            Pizza = pizza;
            CalculateTotalPrice();
            CalculateTimeToPrepare();
        }

        protected Order() { }

        public Pizza Pizza { get; set; }
        public int TimeToPrepare { get; set; }
        public double TotalPrice { get; set; }

        void CalculateTotalPrice()
        {
            TotalPrice = Pizza.Size.Price +
                (Pizza.PizzaCustomizations == null ? 0 :
                Pizza.PizzaCustomizations.Sum(x => x.Customization.Price));
        }

        void CalculateTimeToPrepare()
        {
            TimeToPrepare = Pizza.Size.TimeToPrepare +
                Pizza.Flavor.AdicionalTime +
                (Pizza.PizzaCustomizations == null ? 0 : Pizza.PizzaCustomizations.Sum(x => x.Customization.AdicionalTime));
        }
    }
}
