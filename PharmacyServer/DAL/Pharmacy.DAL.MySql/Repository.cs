using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Pharmacy.DAL.Contract;

namespace Pharmacy.DAL.MySql
{
    public class Repository<T> : IRepository<T> where T : IEntity
    {
        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerator<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerator<T>> GetWhereAsync(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task RemoveWhereAsync(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
