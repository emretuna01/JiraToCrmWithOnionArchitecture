using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Domain.Crm.Entities;
using WebProjectsWithOnionArchitecture.Persist.Crm.Repositories;
using WebProjectsWithOnionArchitecture.Persist.DbContext;

namespace WebProjectsWithOnionArchitecture.Persist.Crm.DbRepositories
{
    public class CrmTaskRepository : DbRepository<CrmTask>, ICrmTaskRepository
    {
        public CrmTaskRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
