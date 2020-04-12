using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CFPP.Database.iRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        T Get(int Id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        //Add
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        //remove
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);


    }
}
