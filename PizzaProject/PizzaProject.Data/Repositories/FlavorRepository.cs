using System;
using Microsoft.Extensions.Configuration;
using PizzaProject.Data.Core;
using PizzaProject.Domain.Entities;
using PizzaProject.Domain.Repositories;

namespace PizzaProject.Data.Repositories
{
    public class FlavorRepository : Repository<Flavor>, IFlavorRepository
    {
        public FlavorRepository(PizzaProjectContext context)
            :base(context, "Flavors")
        { }
    }
}
