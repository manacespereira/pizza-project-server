using System;
using System.Collections.Generic;
using PizzaProject.Domain.Core;
using PizzaProject.Domain.Entities;
using PizzaProject.Domain.Queries.CustomizationQueries;
using PizzaProject.Domain.Repositories;

namespace PizzaProject.Domain.QueryHandlers
{
    public class PizzaSizeQueryHandler : IQueryHandler<GetAllPizzaSizesQuery, IEnumerable<PizzaSize>>
    {
        private readonly IPizzaSizeRepository pizzaSizeRepository;

        public PizzaSizeQueryHandler(IPizzaSizeRepository pizzaSizeRepository)
        {
            this.pizzaSizeRepository = pizzaSizeRepository;
        }

        public IEnumerable<PizzaSize> Handle(GetAllPizzaSizesQuery query)
        {
            return pizzaSizeRepository.FindAll();
        }
    }
}
