using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_commerce.Core.Entities;
using e_commerce.Core.RepositoriesInterfaces;
using e_commerce.Repository.DbContexts;

namespace e_commerce.Repository.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreContext context;
        private Hashtable repositories;

        public UnitOfWork(StoreContext context)
        {
            this.context = context;
            repositories = new Hashtable();
        }
        public IGenericRepository<T> Repository<T>() where T : SharedEntity
        {
            var type = typeof(T).Name;
            if (!repositories.ContainsKey(type))
            {
                var repository = new GenericRepository<T>(context);
                repositories.Add(type, repository);
            }
            return repositories[type] as IGenericRepository<T>;
        }

        public async Task<int> Save()
            => await context.SaveChangesAsync();
    }
}
