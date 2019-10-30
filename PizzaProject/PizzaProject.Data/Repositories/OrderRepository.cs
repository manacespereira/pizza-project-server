using System;
using System.Collections.Generic;
using Dapper;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PizzaProject.Data.Core;
using PizzaProject.Domain.Entities;
using PizzaProject.Domain.Repositories;

namespace PizzaProject.Data.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(PizzaProjectContext context)
            :base(context, "Orders")
        { }

        public IEnumerable<Order> FindAllOrders()
        {
            return dbSet.Include(x => x.Pizza.Flavor).Include(x => x.Pizza.Size).Include(x => x.Pizza.PizzaCustomizations).ThenInclude(x => x.Customization);
        }
    }
}
