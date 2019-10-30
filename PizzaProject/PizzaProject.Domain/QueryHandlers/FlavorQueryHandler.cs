using System;
using System.Collections.Generic;
using PizzaProject.Domain.Core;
using PizzaProject.Domain.Entities;
using PizzaProject.Domain.Queries.FlavorQueries;
using PizzaProject.Domain.Repositories;

namespace PizzaProject.Domain.QueryHandlers
{
    public class FlavorQueryHandler : IQueryHandler<GetAllFlavorsQuery, IEnumerable<Flavor>>
    {
        private readonly IFlavorRepository flavorRepository;

        public FlavorQueryHandler(IFlavorRepository flavorRepository)
        {
            this.flavorRepository = flavorRepository;
        }

        public IEnumerable<Flavor> Handle(GetAllFlavorsQuery query)
        {
            return flavorRepository.FindAll();
        }
    }
}
