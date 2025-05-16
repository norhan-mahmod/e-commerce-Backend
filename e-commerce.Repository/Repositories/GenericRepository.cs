using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_commerce.Core.Entities;
using e_commerce.Core.RepositoriesInterfaces;
using e_commerce.Core.SpecificationPattern;
using e_commerce.Repository.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : SharedEntity
    {
        private readonly StoreContext context;

        public GenericRepository(StoreContext context)
        {
            this.context = context;
        }
        public async Task Add(T entity)
            => await context.Set<T>().AddAsync(entity);

        public void Delete(T entity)
            => context.Set<T>().Remove(entity);

        public async Task<List<T>> GetAllAsync()
            => await context.Set<T>().ToListAsync();

        public async Task<T> GetByIdAsync(int id)
            => await context.Set<T>().FindAsync(id);

        public void Update(T entity)
            => context.Set<T>().Update(entity);

        public async Task<List<T>> GetAllWithSpecAsync(ISpecification<T> spec)
            => await ApplySpecification(spec).ToListAsync();

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
            => SpecificationEvaluator<T>.GetQuery(context.Set<T>(), spec);
    }
}
