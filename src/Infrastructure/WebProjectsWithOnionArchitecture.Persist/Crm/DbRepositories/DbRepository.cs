using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Domain.Crm.Common;
using WebProjectsWithOnionArchitecture.Persist.DbContext;

namespace WebProjectsWithOnionArchitecture.Persist.Crm.Repositories
{
    public class DbRepository<T> : IDbRepository<T> where T : BaseCrmEntity
    {
        readonly ApplicationDbContext _applicationDbContext;
        public DbRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        private DbSet<T> Table { get => _applicationDbContext.Set<T>(); }


        public async Task<int> AddAsync(T type)
        {
            await Table.AddAsync(type);
            return await _applicationDbContext.SaveChangesAsync();
        }

        public Task<List<T>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetWhere(Func<T, bool> method)
        {
            throw new NotImplementedException();
        }
    }
}
