using Microsoft.EntityFrameworkCore;
using Pharmacy.DAL.Contract;

namespace Pharmacy.DAL.MySql
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IRepositoryProvider _repositoryProvider;
        private readonly DbContext _dbContext;

        public UnitOfWork(
            DbContext dbContext,
            IRepositoryProvider repositoryProvider)
        {
            _dbContext = dbContext;
            _repositoryProvider = repositoryProvider;
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public IRepository<T> GetRepository<T>() where T : IEntity
        {
            return _repositoryProvider.GetRepository<T>();
        }
    }
}
