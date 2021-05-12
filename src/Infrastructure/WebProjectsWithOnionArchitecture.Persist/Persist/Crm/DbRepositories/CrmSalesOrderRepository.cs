using WebProjectsWithOnionArchitecture.Application.Application.Crm.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities;
using WebProjectsWithOnionArchitecture.Persist.Persist.App.Common;
using WebProjectsWithOnionArchitecture.Persist.Persist.Crm.DbContext;

namespace WebProjectsWithOnionArchitecture.Persist.Persist.Crm.DbRepositories
{
    public class CrmSalesOrderRepository : DbRepository<CrmSalesOrder>, ICrmSalesOrderRepository
    {
        public CrmSalesOrderRepository(ApplicationCrmDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
