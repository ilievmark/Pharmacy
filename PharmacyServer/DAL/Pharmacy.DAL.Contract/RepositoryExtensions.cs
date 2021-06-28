﻿using System.Threading.Tasks;

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

    }
}
