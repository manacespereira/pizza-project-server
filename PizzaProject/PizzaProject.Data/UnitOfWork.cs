using System;
using PizzaProject.Domain.Core;

namespace PizzaProject.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PizzaProjectContext _context;

        public UnitOfWork(PizzaProjectContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
