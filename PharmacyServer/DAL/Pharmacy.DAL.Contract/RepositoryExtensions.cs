using System;
using System.Threading.Tasks;

namespace Pharmacy.DAL.Contract
{
    public static class RepositoryExtensions
    {
        public static Task<T> GetByIdAsync<T>(this IRepository<T> @this, int id)
            where T : IEntity
                => @this.GetWhereAsync(e => e.Id == id);

        public static Task RemoveByIdAsync<T>(this IRepository<T> @this, int id)
            where T : IEntity
                => @this.RemoveWhereAsync(e => e.Id == id);

        public static async Task RemoveWhereAsync<T>(this IRepository<T> @this, Func<T, bool> predicate)
            where T : IEntity
                => @this.Remove(await @this.GetWhereAsync(predicate));
    }
}
