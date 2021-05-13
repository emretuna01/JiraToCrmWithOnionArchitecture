using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application;
using WebProjectsWithOnionArchitecture.Domain;
using WebProjectsWithOnionArchitecture.Infrastruct.ServiceManagers.Crm.Common;
using WebProjectsWithOnionArchitecture.Infrastruct.ServiceManagers.Crm.Services;
using WebProjectsWithOnionArchitecture.Persist;

namespace WebProjectsWithOnionArchitecture.Infrastruct
{
    public class Startup
    {
        public IConfiguration Configuration { get;}

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddDomainServices();
            serviceCollection.AddPersistanceServices(Configuration);
            serviceCollection.AddApplicationServices();                       
            serviceCollection.AddControllers();
            serviceCollection.AddTransient<NtlmAuthenticator>();
            serviceCollection.AddScoped<CrmServices>();           
            serviceCollection.Configure<Configuration>(option => Configuration.GetSection("CrmRootParameters").Bind(option));



        }

        public void Configure(IApplicationBuilder applicationBuilder)
        {

            applicationBuilder.UseRouting();           

            applicationBuilder.UseAuthorization();

            applicationBuilder.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

   
        }

    }


    


}
