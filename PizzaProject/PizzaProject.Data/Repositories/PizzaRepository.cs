using System;
using Microsoft.Extensions.Configuration;
using PizzaProject.Data.Core;
using PizzaProject.Domain.Entities;
using PizzaProject.Domain.Repositories;

namespace PizzaProject.Data.Repositories
{
    public class PizzaRepository : Repository<Pizza>, IPizzaRepository
    {
        public PizzaRepository(PizzaProjectContext context)
            :base(context, "Pizzas")
        { }
    }
}
