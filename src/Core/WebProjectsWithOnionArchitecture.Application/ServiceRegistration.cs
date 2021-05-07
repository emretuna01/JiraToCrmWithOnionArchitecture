using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Crm.Feature.Queries.GetCrmWhoAmI;

namespace WebProjectsWithOnionArchitecture.Application
{
    public static class ServiceRegistration
    {

        public static void AddApplicationServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<GetCrmWhoAmIHandler>();
        }
    }
}
