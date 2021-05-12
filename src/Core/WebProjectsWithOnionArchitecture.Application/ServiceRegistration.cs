using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Commands.InsertUser;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Queries.GetCrmUser;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Commands.UpdateCrmUser;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmUser;

namespace WebProjectsWithOnionArchitecture.Application
{
    public static class ServiceRegistration
    {

        public static void AddApplicationServices(this IServiceCollection serviceCollection)
        {
            //TODO:MediatR library will be added here.            

            serviceCollection.AddTransient<InsertUserCommandHandler>();
            serviceCollection.AddTransient<InsertUserCommandResponse>();
            serviceCollection.AddTransient<GetCrmUserHandler>();
            serviceCollection.AddTransient<UpdateCrmUserCommandResponse>();



        }
    }
}
