using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebProjectsWithOnionArchitecture.Application.Application.App.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Domain.Entities.App.Common;
using WebProjectsWithOnionArchitecture.Persist.Persist.Crm.DbContext;

namespace WebProjectsWithOnionArchitecture.Persist.Persist.App.Common
{
    public class DbRepository<T> : IDbRepository<T> where T : BaseEntity
    {
        readonly ApplicationCrmDbContext _applicationDbContext;
        public DbRepository(ApplicationCrmDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        private DbSet<T> Table { get => _applicationDbContext.Set<T>(); }


        public async Task<int> AddAsync(T type)
        {
            await Table.AddAsync(type);
            return await _applicationDbContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAsync()
        {
            return await Table.ToListAsync();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetWhereAsync(Expression<Func<T, bool>> expression)
        {
            return await Table.Where(expression).FirstOrDefaultAsync();
        }

        //TODO:Count control will be added
        public async Task<int> UpdateAsync(T type, Guid guid)
        {
            var existEntry =await Table.FindAsync(guid);
            _applicationDbContext.Entry(existEntry).CurrentValues.SetValues(type);
            return await _applicationDbContext.SaveChangesAsync();

        }
    }
}
