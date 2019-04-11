using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PlayersPool.Data.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        void Delete(int ID);
        void Delete(T entity);
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        T GetByID(int ID);
        void Insert(T entity);
        void Save();
        void Update(T entity);
    }
}