using System;
using System.Collections.Generic;
using Pharmacy.DAL.Contract;

namespace Pharmacy.DAL.MySql
{
    public class RepositoryContainer : IRepositoryProvider, IRepositoryRegistrar
    {
        public Dictionary<Type, object> _container;

        public RepositoryContainer()
        {
            _container = new Dictionary<Type, object>();
        }

        public IRepository<T> GetRepository<T>() where T : IEntity
        {
            return _container[typeof(T)] as IRepository<T>;
        }

        public void RegisterRepository<T>(IRepository<T> repository) where T : IEntity
        {
            _container[typeof(T)] = repository;
        }
    }
}
