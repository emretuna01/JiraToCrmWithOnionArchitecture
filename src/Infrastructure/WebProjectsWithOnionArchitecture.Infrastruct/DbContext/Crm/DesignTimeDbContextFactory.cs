using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Persist.Persist.Crm.DbContext;

namespace WebProjectsWithOnionArchitecture.Infrastruct.DbContext.Crm
{
    public abstract class DesignTimeDbContextFactory<TContext> : IDesignTimeDbContextFactory<TContext> where TContext : ApplicationCrmDbContext
    {
        protected abstract TContext CreateNewInstance(DbContextOptions<TContext> dbContextOptions);

        public TContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<TContext> dbContextOptionsBuilder = new DbContextOptionsBuilder<TContext>();
            IConfiguration configuration = new ConfigurationBuilder().SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../WebProjectsWithOnionArchitecture.Infrastruct")).AddJsonFile("appsettings.json").Build();
            dbContextOptionsBuilder.UseSqlite(configuration.GetConnectionString("SqlLite"),p=>p.MigrationsAssembly("WebProjectsWithOnionArchitecture.Infrastruct"));
            return CreateNewInstance(dbContextOptionsBuilder.Options);
        }
    }
}
