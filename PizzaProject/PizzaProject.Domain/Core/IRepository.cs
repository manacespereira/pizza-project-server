using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PizzaProject.Domain.Core
{
    public interface IRepository<T> where T : Entity
    {

        public void Add(T entity);

        public void Update(T entity);

        public T Find(string UId);

        public IEnumerable<T> FindAll();

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        public void Delete(string UId);

        public void Delete(Expression<Func<T, bool>> predicate);

        void Dispose();
    }
}
