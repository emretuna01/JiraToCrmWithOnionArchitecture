using Microsoft.EntityFrameworkCore;
using WebProjectsWithOnionArchitecture.Application.Application.App.Interfaces.DbContext;
using WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities;

namespace WebProjectsWithOnionArchitecture.Application.Application.Crm.Interfaces.DbContext
{
    //TODO:Orm aracındaki contexttir. Arayüzü application katmanındadır
    /// <summary>
    /// Orm aracındaki persistence katmanında contextin arayüzüdür.
    /// </summary>
    public interface IApplicationCrmDbContext: IApplicationDbContext
    {
        public DbSet<CrmUser> CrmUsers { get; set; }
        public DbSet<CrmTask> CrmTasks { get; set; }
        public DbSet<CrmAccount> CrmAccounts { get; set; }

    }
}
