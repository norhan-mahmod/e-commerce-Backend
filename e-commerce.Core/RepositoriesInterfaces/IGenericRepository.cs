using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_commerce.Core.Entities;
using e_commerce.Core.SpecificationPattern;

namespace e_commerce.Core.RepositoriesInterfaces
{
    public interface IGenericRepository<T> where T : SharedEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<List<T>> GetAllWithSpecAsync(ISpecification<T> spec);
    }
}
