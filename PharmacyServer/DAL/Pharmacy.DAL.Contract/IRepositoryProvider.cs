namespace Pharmacy.DAL.Contract
{
    public interface IRepositoryProvider
    {
        IRepository<T> GetRepository<T>() where T : IEntity;
    }
}
