using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

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
            serviceCollection.AddControllers();
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
