using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Interfaces.UnitOfWork;
using WebProjectsWithOnionArchitecture.Persist.Persist.Crm.DbContext;

namespace WebProjectsWithOnionArchitecture.Persist.Persist.Crm.UnitOfWork
{
    public class UnitCrmOfWork : IUnitCrmOfWork
    {
        readonly ApplicationCrmDbContext _applicationDbContext;
        public ICrmUserRepository CrmUserRepository { get; }
        public ICrmAccountRepository CrmAccountRepository { get; }
        public ICrmTaskRepository CrmTaskRepository { get; }
        public ICrmSalesOrderRepository CrmSalesOrderRepository { get; }

        public UnitCrmOfWork(ApplicationCrmDbContext applicationDbContext, 
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
        
        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _applicationDbContext.Database.BeginTransactionAsync();
        }
    }
}
