using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WhiteLagon.Domain.Entities;

namespace WhiteLagon.Application.Common.Interfaces
{
    public interface IVillaRepository
    {
        IEnumerable<Villa> GetAll(Expression<Func<IVillaRepository, bool>>? filter = null, string? includeProperties = null);
        IEnumerable<Villa> Get(Expression<Func<IVillaRepository, bool>>? filter, string? includeProperties = null);
        void Add(Villa entity);
        void Update(Villa entity);
        void Remove(Villa entity);
        void Save();
    }
}
