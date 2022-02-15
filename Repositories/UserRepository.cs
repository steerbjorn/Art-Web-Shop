using ArtWebshop.Data;
using ArtWebshop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ArtWebshop.Repositories
{
    public class UserRepository : IRepository<ApplicationUser>
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddAsync(ApplicationUser entity)
        {
            _context.AddAsync(entity);
        }

        public async Task<IEnumerable<ApplicationUser>> All()
        {
            return await _context.Set<ApplicationUser>().ToListAsync();
        }

        public async Task<IEnumerable<ApplicationUser>> Find(Expression<Func<ApplicationUser, bool>> predicate)
        {
            return await _context.Set<ApplicationUser>().AsQueryable().Where(predicate).ToListAsync();
        }

        public async Task<ApplicationUser> GetAsync(string id)
        {
            return await _context.FindAsync<ApplicationUser>(id);
        }

        public void SaveChangesAsync()
        {
            _context.SaveChangesAsync();
        }

        public ApplicationUser Update(ApplicationUser entity)
        {
            return _context.Update(entity).Entity;
        }
    }
}
