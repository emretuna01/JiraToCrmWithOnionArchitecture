using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities;
using WebProjectsWithOnionArchitecture.Persist.Crm.Repositories;
using WebProjectsWithOnionArchitecture.Persist.DbContext;

namespace WebProjectsWithOnionArchitecture.Persist.Crm.DbRepositories
{
    public class CrmSalesOrderRepository : DbRepository<CrmSalesOrder>, ICrmSalesOrderRepository
    {
        public CrmSalesOrderRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
