using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Temples.Repository.Interface
{
    /// <summary>
    /// A generic reporitorty interface that will be inherited by all the repository class
    /// </summary>
    /// <typeparam name="TEnt"></typeparam>
    public interface IGenericRepository<T> where T:class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void Remove(T entity);
    }
}
