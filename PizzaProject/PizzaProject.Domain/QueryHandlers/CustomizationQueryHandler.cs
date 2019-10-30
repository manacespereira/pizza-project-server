using System;
using System.Collections.Generic;
using PizzaProject.Domain.Core;
using PizzaProject.Domain.Entities;
using PizzaProject.Domain.Queries.CustomizationQueries;
using PizzaProject.Domain.Repositories;

namespace PizzaProject.Domain.QueryHandlers
{
    public class CustomizationQueryHandler : IQueryHandler<GetAllCustomizationsQuery, IEnumerable<Customization>>
    {
        private readonly ICustomizationRepository customizationRepository;

        public CustomizationQueryHandler(ICustomizationRepository customizationRepository)
        {
            this.customizationRepository = customizationRepository;
        }

        public IEnumerable<Customization> Handle(GetAllCustomizationsQuery query)
        {
            return customizationRepository.FindAll();
        }
    }
}
