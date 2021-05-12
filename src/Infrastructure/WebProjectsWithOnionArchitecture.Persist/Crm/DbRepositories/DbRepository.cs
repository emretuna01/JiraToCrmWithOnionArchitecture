using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Domain.Entities;
using WebProjectsWithOnionArchitecture.Domain.Entities.App.Common;
using WebProjectsWithOnionArchitecture.Persist.DbContext;

namespace WebProjectsWithOnionArchitecture.Persist.Crm.Repositories
{
    public class DbRepository<T> : IDbRepository<T> where T : BaseEntity
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
        public async Task<int> UpdateAsync(T type, Guid guid)
        {
            var existEntry =await Table.FindAsync(guid);
            _applicationDbContext.Entry(existEntry).CurrentValues.SetValues(type);
            return await _applicationDbContext.SaveChangesAsync();

        }
    }
}
