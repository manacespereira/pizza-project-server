using System;
namespace PizzaProject.Domain.Core
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
