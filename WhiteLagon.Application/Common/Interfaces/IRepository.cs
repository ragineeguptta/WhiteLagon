using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WhiteLagon.Domain.Entities;

namespace WhiteLagon.Application.Common.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Get(Expression<Func<T, bool>>? filter, string? includeProperties = null);
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
        void Add(T entity);
        bool Any(Expression<Func<T, bool>> filter);
        void Remove(T entity);
    }
}
