namespace Pharmacy.DAL.Contract
{
    public interface IUnitOfWork
    {
        void Commit();

        IRepository<T> GetRepository<T>() where T : IEntity;
    }
}
