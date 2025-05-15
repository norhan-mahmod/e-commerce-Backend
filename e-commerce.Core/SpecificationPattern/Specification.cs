using e_commerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Core.SpecificationPattern
{
    public class Specification<T> : ISpecification<T> where T : SharedEntity
    {
        public Expression<Func<T, bool>> Criteria { get ; set; }
        public List<Expression<Func<T, object>>> Includes { get ; set; } = new List<Expression<Func<T, object>>> ();
        public Expression<Func<T, object>> OrderBy { get ; set; }
        public Expression<Func<T, object>> OrderByDesc { get ; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
        public bool IsPaginationEnabled { get ; set ; }
        public void AddInclude(Expression<Func<T, object>> include)
        {
            Includes.Add(include);
        }
        public void AddOrderBy(Expression<Func<T, object>> orderBy)
        {
            OrderBy = orderBy;
        }
        public void AddOrderByDesc(Expression<Func<T,object>> orderByDesc)
        {
            OrderByDesc = orderByDesc;
        }
        public void ApplyPagination(int pageIndex, int pageSize)
        {
            IsPaginationEnabled = true;
            Skip = pageSize * (pageIndex - 1);
            Take = pageSize;
        }
    }
}
