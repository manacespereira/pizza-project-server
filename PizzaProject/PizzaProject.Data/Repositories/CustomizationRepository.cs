using System;
using Microsoft.Extensions.Configuration;
using PizzaProject.Data.Core;
using PizzaProject.Domain.Entities;
using PizzaProject.Domain.Repositories;

namespace PizzaProject.Data.Repositories
{
    public class CustomizationRepository : Repository<Customization>, ICustomizationRepository
    {
        public CustomizationRepository(PizzaProjectContext context)
            : base(context, "Customizations")
        {
            
        }
    }
}
