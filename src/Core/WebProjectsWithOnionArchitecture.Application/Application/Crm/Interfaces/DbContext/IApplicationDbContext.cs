using Microsoft.EntityFrameworkCore;
using WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities;

namespace WebProjectsWithOnionArchitecture.Application.Application.Crm.Interfaces.DbContext
{
    //TODO:Orm aracındaki contexttir. Arayüzü application katmanındadır
    /// <summary>
    /// Orm aracındaki persistence katmanında contextin arayüzüdür.
    /// </summary>
    public interface IApplicationDbContext
    {
        public DbSet<CrmUser> CrmUser { get; set; }
        public DbSet<CrmTask> CrmTask { get; set; }
        public DbSet<CrmAccount> CrmAccount { get; set; }

    }
}
