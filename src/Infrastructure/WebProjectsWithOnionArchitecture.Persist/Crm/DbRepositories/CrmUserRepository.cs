using Microsoft.EntityFrameworkCore;
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
    public class CrmUserRepository : DbRepository<CrmUser>, ICrmUserRepository
    {
        readonly ApplicationDbContext _applicationDbContext;

        public CrmUserRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        private DbSet<CrmUser> crmUser { get { return _applicationDbContext.Set<CrmUser>(); } }

        public async Task<List<CrmUser>> GetCrmUserFromDbByName(string username, string password)
        {
               return await  crmUser.ToListAsync();
        }
    }
}
