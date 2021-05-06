﻿using Microsoft.EntityFrameworkCore;
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
    public abstract class DesignTimeDbContextFactory<TContext> : IDesignTimeDbContextFactory<TContext> where TContext : ApplicationDbContext
    {
        protected abstract TContext CreateNewInstance(DbContextOptions<TContext> dbContextOptions);

        public TContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<TContext> dbContextOptionsBuilder = new DbContextOptionsBuilder<TContext>();
            IConfiguration configuration = new ConfigurationBuilder().SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../WebProjectsWithOnionArchitecture.Persist")).AddJsonFile("appsettings.json").Build();
            dbContextOptionsBuilder.UseSqlite(configuration.GetConnectionString("SqlLite"));
            return CreateNewInstance(dbContextOptionsBuilder.Options);
        }
    }
}
