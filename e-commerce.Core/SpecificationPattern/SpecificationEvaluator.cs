using e_commerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Core.SpecificationPattern
{
    public static class SpecificationEvaluator<T> where T : SharedEntity
    {
        public static IQueryable<T> GetQuery(IQueryable<T> inputQuery , ISpecification<T> spec)
        {
            var query = inputQuery;
            if (spec.Criteria is not null)
                query = query.Where(spec.Criteria);
            query = spec.Includes.Aggregate()
        }
    }
}
