using System;
using System.Collections.Generic;
using PizzaProject.Domain.Core;
using PizzaProject.Domain.Entities;

namespace PizzaProject.Domain.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> FindAllOrders();
    }
}
