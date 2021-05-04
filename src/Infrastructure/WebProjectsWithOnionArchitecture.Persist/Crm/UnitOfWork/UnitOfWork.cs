using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.UnitOfWork;
using WebProjectsWithOnionArchitecture.Persist.DbContext;

namespace WebProjectsWithOnionArchitecture.Persist.Crm.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ApplicationDbContext _applicationDbContext;

        public UnitOfWork(ApplicationDbContext applicationDbContext, 
                          ICrmUserRepository crmUserRepository, 
                          ICrmAccountRepository crmAccountRepository, 
                          ICrmTaskRepository crmTaskRepository,
                          ICrmSalesOrderRepository crmSalesOrderRepository)
        {
            _applicationDbContext = applicationDbContext;
            CrmUserRepository = crmUserRepository;
            CrmAccountRepository = crmAccountRepository;
            CrmTaskRepository = crmTaskRepository;
            CrmSalesOrderRepository = crmSalesOrderRepository;

        }

        public ICrmUserRepository CrmUserRepository { get; }
        public ICrmAccountRepository CrmAccountRepository { get; }
        public ICrmTaskRepository CrmTaskRepository { get; }
        public ICrmSalesOrderRepository CrmSalesOrderRepository { get; }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _applicationDbContext.Database.BeginTransactionAsync();
        }
    }
}
