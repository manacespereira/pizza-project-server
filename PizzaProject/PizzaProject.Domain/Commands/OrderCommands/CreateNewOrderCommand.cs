using System;
using Flunt.Validations;
using PizzaProject.Domain.Core;
using PizzaProject.Domain.Entities;

namespace PizzaProject.Domain.Commands.OrderCommands
{
    public class CreateNewOrderCommand : Command
    {
        public CreateNewOrderCommand(Pizza pizza)
        {
            Pizza = pizza;
        }
        protected CreateNewOrderCommand() { }

        public Pizza Pizza { get; set; }

        public override void Validate()
        {
            AddNotifications(new Contract()
                .IsNotNull(Pizza.Flavor, nameof(Pizza.Flavor), "Precisa escolher o sabor da Pizza")
                .IsNotNull(Pizza.Size, nameof(Pizza.Size), "Precisa escolher o tamanho da pizza"));
        }
    }
}
