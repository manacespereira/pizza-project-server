using System;
using Microsoft.Extensions.Configuration;
using PizzaProject.Data.Core;
using PizzaProject.Domain.Entities;
using PizzaProject.Domain.Repositories;

namespace PizzaProject.Data.Repositories
{
    public class PizzaSizeRepository : Repository<PizzaSize>, IPizzaSizeRepository
    {
        public PizzaSizeRepository(PizzaProjectContext context)
            :base(context, "PizzaSizes")
        { }
    }
}
