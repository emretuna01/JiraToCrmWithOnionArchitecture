using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Persist.DbContext;

namespace WebProjectsWithOnionArchitecture.Infrastruct.Crm.DbContext
{
    public class DesignTimeDbContextFactory<TContext> : IDesignTimeDbContextFactory<TContext> where TContext : ApplicationDbContext
    {
        public TContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<TContext> dbContextOptionsBuilder = new DbContextOptionsBuilder<TContext>();
            IConfiguration configuration = new ConfigurationBuilder().SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../WebProjectsWithOnionArchitecture.Persist")).AddJsonFile("appsettings.json").Build();
            dbContextOptionsBuilder.UseSqlite(configuration.GetConnectionString("SqlLite"));
        }
    }
}
