using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Persist.Crm.DbRepositories;
using WebProjectsWithOnionArchitecture.Persist.DbContext;

namespace WebProjectsWithOnionArchitecture.Persist
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(dbContextOptions => dbContextOptions.UseSqlite());
            serviceCollection.AddTransient<ICrmUserRepository, CrmUserRepository>();
        }

    }
}
