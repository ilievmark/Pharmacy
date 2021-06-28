using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pharmacy.DAL.Contract
{
    public interface IRepository<T> where T : IEntity
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetWhereAsync(Func<T, bool> predicate);

        void Remove(T entity);

        void Update(T entity);

        Task AddAsync(T entity);
    }
}
