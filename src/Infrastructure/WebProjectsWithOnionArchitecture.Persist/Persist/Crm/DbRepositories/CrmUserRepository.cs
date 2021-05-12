using WebProjectsWithOnionArchitecture.Application.Application.Crm.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities;
using WebProjectsWithOnionArchitecture.Persist.Persist.App.Common;
using WebProjectsWithOnionArchitecture.Persist.Persist.Crm.DbContext;

namespace WebProjectsWithOnionArchitecture.Persist.Persist.Crm.DbRepositories
{
    public class CrmUserRepository : DbRepository<CrmUser>, ICrmUserRepository
    {
        public CrmUserRepository(ApplicationCrmDbContext applicationDbContext) : base(applicationDbContext)
        {           
        }
    }
}
