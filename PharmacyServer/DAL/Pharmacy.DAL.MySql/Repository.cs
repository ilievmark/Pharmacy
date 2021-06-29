using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pharmacy.DAL.Contract;

namespace Pharmacy.DAL.MySql
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        protected DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
            => await _context.Set<T>().AddAsync(entity);

        public async Task<IEnumerable<T>> GetAllAsync()
            => await _context.Set<T>().ToListAsync();

        public async Task<T> GetWhereAsync(Func<T, bool> predicate)
            => await _context.Set<T>().FirstOrDefaultAsync(e => predicate(e));

        public void Remove(T entity)
            => _context.Set<T>().Remove(entity);

        public void Update(T entity)
            => _context.Set<T>().Update(entity);
    }
}
