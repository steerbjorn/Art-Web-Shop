using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ArtWebshop.Repositories
{
    public interface IRepository<T>
    {
        void AddAsync(T entity);
        T Update(T entity);
        Task<T> GetAsync(string id);
        Task<IEnumerable<T>> All();
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
        void SaveChangesAsync();
    }
}
