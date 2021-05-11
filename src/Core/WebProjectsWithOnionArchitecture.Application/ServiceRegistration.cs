using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Commands.InsertCrmUser;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmWhoAmI;

namespace WebProjectsWithOnionArchitecture.Application
{
    public static class ServiceRegistration
    {

        public static void AddApplicationServices(this IServiceCollection serviceCollection)
        {
            //MediatR library will be added here.
            serviceCollection.AddTransient<GetCrmWhoAmIHandler>();
            serviceCollection.AddTransient<InsertCrmUserCommandHandler>();
            serviceCollection.AddTransient<InsertCrmUserCommandResponse>();

        }
    }
}
