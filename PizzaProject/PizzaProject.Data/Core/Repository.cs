using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PizzaProject.Domain.Core;
using Microsoft.Data.Sqlite;

namespace PizzaProject.Data.Core
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected PizzaProjectContext context;
        protected DbSet<T> dbSet;
        protected string tableName;

        public Repository(PizzaProjectContext context, string tableName)
        {
            this.context = context;
            dbSet = this.context.Set<T>();
            this.tableName = tableName;
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            context.Update(entity);
        }

        public T Find(string UId)
        {
            T entity = null;

            using (var _conn = new SqliteConnection(context.ConnectionString))
                entity = _conn.Query<T>($"SELECT * FROM {tableName} WHERE UId = @UId", new { UId }).FirstOrDefault();

            return entity;
        }

        public IEnumerable<T> FindAll()
        {
            IEnumerable<T> entities = null;

            using (var _conn = new SqliteConnection(context.ConnectionString))
                entities = _conn.Query<T>($"SELECT * FROM {tableName}");

            return entities;
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = dbSet;

            if (includeProperties != null)
                query = includeProperties.Aggregate(query, (current, include) => current.Include(include));

            if (predicate != null)
                query = query.Where(predicate);

            return query;
        }

        public void Delete(string UId)
        {
            context.Remove(Find(UId));
        }

        public void Delete(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = dbSet.Where(predicate);
            context.RemoveRange(query);
        }

        public void Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(true);
        }
    }

}
