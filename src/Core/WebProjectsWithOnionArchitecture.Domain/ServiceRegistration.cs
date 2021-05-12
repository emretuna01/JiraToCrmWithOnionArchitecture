using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities;

namespace WebProjectsWithOnionArchitecture.Domain
{
    public static class ServiceRegistration
    {

        public static void AddDomainServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<CrmUser>();
        }
    }
}
