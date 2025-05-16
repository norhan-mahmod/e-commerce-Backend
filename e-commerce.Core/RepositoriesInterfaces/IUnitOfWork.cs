using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_commerce.Core.Entities;

namespace e_commerce.Core.RepositoriesInterfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<T> Repository<T>() where T : SharedEntity;
        Task<int> Save();
    }
}
