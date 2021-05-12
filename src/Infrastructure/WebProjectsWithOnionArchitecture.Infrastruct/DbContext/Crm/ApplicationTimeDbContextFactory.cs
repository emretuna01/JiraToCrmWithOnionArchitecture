using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Persist.Persist.Crm.DbContext;

namespace WebProjectsWithOnionArchitecture.Infrastruct.DbContext.Crm
{
    public class ApplicationTimeDbContextFactory: DesignTimeDbContextFactory<ApplicationCrmDbContext>
    {
        protected override ApplicationCrmDbContext CreateNewInstance(DbContextOptions<ApplicationCrmDbContext> dbContextOptions)
        {
            return new ApplicationCrmDbContext(dbContextOptions);
        }

    }
}
