using System;
using System.Collections.Generic;
using PizzaProject.Domain.Core;
using PizzaProject.Domain.Entities;
using PizzaProject.Domain.Queries.CustomizationQueries;
using PizzaProject.Domain.Repositories;

namespace PizzaProject.Domain.QueryHandlers
{
    public class OrderQueryHandler : IQueryHandler<GetAllOrdersQuery, IEnumerable<Order>>
    {
        private readonly IOrderRepository orderRepository;

        public OrderQueryHandler(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public IEnumerable<Order> Handle(GetAllOrdersQuery query)
        {
            return orderRepository.FindAllOrders();
        }
    }
}
