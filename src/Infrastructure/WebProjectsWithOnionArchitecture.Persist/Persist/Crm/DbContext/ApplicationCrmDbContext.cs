using Microsoft.EntityFrameworkCore;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Interfaces.DbContext;
using WebProjectsWithOnionArchitecture.Domain.Entities.App.Entities;
using WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities;

namespace WebProjectsWithOnionArchitecture.Persist.Persist.Crm.DbContext
{
    public class ApplicationCrmDbContext : Microsoft.EntityFrameworkCore.DbContext, IApplicationCrmDbContext
    {
        //TODO:Orm aracındaki contexttir. Arayüzü application katmanındadır
        /// <summary>
        /// Orm aracındaki contexttir. Arayüzü application katmanındadır
        /// </summary>
        /// <param name="dbContextOptions"></param>
        public ApplicationCrmDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {            
        }
        public DbSet<CrmUser> CrmUsers { get ; set; }
        public DbSet<CrmTask> CrmTasks { get; set; }
        public DbSet<CrmAccountRoot> CrmAccounts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
