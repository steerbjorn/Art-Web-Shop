using ArtWebshop.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ArtWebshop.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected ProductDbContext _productContext;
        
        public Repository(ProductDbContext productDbContext)
        {
            _productContext = productDbContext;

        }
        public virtual void AddAsync(T entity)
        {
            _productContext.AddAsync(entity);
        }

        public virtual async Task<IEnumerable<T>> All()
        {
            return await _productContext.Set<T>().ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            return await _productContext.Set<T>().AsQueryable().Where(predicate).ToListAsync();
        }

        public virtual async Task<T> GetAsync(string id)
        {
            return await _productContext.FindAsync<T>(id);
        }

        public virtual void SaveChangesAsync()
        {
            _productContext.SaveChangesAsync();
        }

        public virtual T Update(T entity)
        {
            return _productContext.Update(entity).Entity;
        }
    }
}
