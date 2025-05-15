using e_commerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Core.SpecificationPattern
{
    public interface ISpecification<T> where T : SharedEntity
    {
        Expression<Func<T, bool>> Criteria { get; set; }
        List<Expression<Func<T, object>>> Includes { get; set; }
        Expression<Func<T, object>> OrderBy { get; set; }
        Expression<Func<T, object>> OrderByDesc { get; set; }
        // For Pagination
        int Skip { get; set; }
        int Take { get; set; }
        bool IsPaginationEnabled { get; set; }
    }
}
