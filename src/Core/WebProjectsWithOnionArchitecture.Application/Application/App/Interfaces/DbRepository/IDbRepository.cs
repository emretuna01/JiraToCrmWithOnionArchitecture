using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Domain.Entities.App.Common;

namespace WebProjectsWithOnionArchitecture.Application.Application.App.Interfaces.DbRepository
{
    public interface IDbRepository<T> where T: BaseEntity
    {
        Task<List<T>> GetAsync();
        Task<T> GetWhereAsync(Expression<Func<T, bool>> expression);
        Task<T> GetByIdAsync(Guid id);
        Task<int> AddAsync(T type);
        Task<int> UpdateAsync(T type, Guid guid);


    }
}
