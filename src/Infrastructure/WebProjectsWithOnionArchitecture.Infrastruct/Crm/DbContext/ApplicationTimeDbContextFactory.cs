using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Persist.DbContext;

namespace WebProjectsWithOnionArchitecture.Infrastruct.Crm.DbContext
{
    public class ApplicationTimeDbContextFactory: DesignTimeDbContextFactory<ApplicationDbContext>
    {
        protected override ApplicationDbContext CreateNewInstance(DbContextOptions<ApplicationDbContext> dbContextOptions)
        {
            return new ApplicationDbContext(dbContextOptions);
        }

    }
}
