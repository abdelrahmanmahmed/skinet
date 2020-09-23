using System;
using System.Linq;
using Core.Entities;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class SpecificationEvaluator<TEnitiy> where TEnitiy : BaseEntity
    {
        public static IQueryable<TEnitiy> GetQuery(IQueryable<TEnitiy> inputQuery, ISpecification<TEnitiy> spec)
        {
            var query = inputQuery;

            if (spec.Criteria != null)
            {
                query = query.Where(spec.Criteria);
            }

            query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));

            return query;
        }
    }
}
