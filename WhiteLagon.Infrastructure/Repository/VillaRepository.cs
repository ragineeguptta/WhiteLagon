using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WhiteLagon.Application.Common.Interfaces;
using WhiteLagon.Domain.Entities;
using WhiteLagon.Infrastructure.Data;

namespace WhiteLagon.Infrastructure.Repository
{
    public class VillaRepository : IVillaRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public void Add(Villa entity)
        {
            _db.Add(entity);
        }

        public IEnumerable<Villa> Get(Expression<Func<IVillaRepository, bool>>? filter, string? includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Villa> GetAll(Expression<Func<IVillaRepository, bool>>? filter = null, string? includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(Villa entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Villa entity)
        {
            throw new NotImplementedException();
        }
    }
}
