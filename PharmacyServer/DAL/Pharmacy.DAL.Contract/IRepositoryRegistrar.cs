namespace Pharmacy.DAL.Contract
{
    public interface IRepositoryRegistrar
    {
        void RegisterRepository<T>(IRepository<T> repository) where T : IEntity;
    }
}
