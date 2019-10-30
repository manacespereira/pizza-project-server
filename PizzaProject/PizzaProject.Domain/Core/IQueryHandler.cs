using System;
namespace PizzaProject.Domain.Core
{
    public interface IQueryHandler<Q, R> where Q : Query where R : class
    {
        R Handle(Q query);
    }
}
