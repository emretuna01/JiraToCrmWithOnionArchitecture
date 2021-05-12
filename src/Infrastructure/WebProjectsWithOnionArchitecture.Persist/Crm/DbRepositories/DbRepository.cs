using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public async Task<List<T>> GetWhereAsync(Expression<Func<T, bool>> expression)
        {
            return await Table.Where(expression).ToListAsync();
        }

        //TODO:Count control will be added
        public async Task<T> UpdateAsync(T type, Guid guid)
        {
            var existEntry =await Table.FindAsync(guid);
            _applicationDbContext.Entry(existEntry).CurrentValues.SetValues(type);
            await _applicationDbContext.SaveChangesAsync();
            return existEntry;
        }
    }
}
