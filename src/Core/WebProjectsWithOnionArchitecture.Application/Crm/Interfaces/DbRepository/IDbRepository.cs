﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Domain.Crm.Common;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.DbRepository
{
    public interface IDbRepository<T> where T: BaseCrmEntity
    {
        Task<List<T>> GetAsync();
        Task<List<T>> GetWhere(Func<T, bool> method);
        Task<T> GetByIdAsync(Guid id);
        Task<int> AddAsync(T type);
        
    }
}
