using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pharmacy.DAL.Contract
{
    public interface IRepository<T> where T : IEntity
    {
        Task<IEnumerator<T>> GetAllAsync();

        Task<IEnumerator<T>> GetWhereAsync(Func<T, bool> predicate);

        Task RemoveWhereAsync(Func<T, bool> predicate);

        Task UpdateAsync(T entity);

        Task AddAsync(T entity);
    }
}
