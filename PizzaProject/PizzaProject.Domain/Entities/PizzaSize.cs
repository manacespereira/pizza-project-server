using System;
using System.Collections.Generic;
using PizzaProject.Domain.Core;

namespace PizzaProject.Domain.Entities
{
    public class PizzaSize : Entity
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Size description that will appear to the costumer</param>
        /// <param name="price">Fixed price</param>
        /// <param name="timeToPrepare">Time to prepare in minutes</param>
        public PizzaSize(string name, double price, int timeToPrepare)
        {
            Name = name;
            Price = price;
            TimeToPrepare = timeToPrepare;
        }

        protected PizzaSize() { }

        public string Name { get; set; }
        public double Price { get; set; }

        /// <summary>
        /// Time to prepare in minutes
        /// </summary>
        public int TimeToPrepare { get; set; }
        public IEnumerable<Pizza> Pizzas { get; set; }
    }
}
