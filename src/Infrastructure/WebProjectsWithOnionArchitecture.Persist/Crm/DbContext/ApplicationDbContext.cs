using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Interfaces.DbContext;
using WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities;

namespace WebProjectsWithOnionArchitecture.Persist.DbContext
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext, IApplicationDbContext
    {
        //TODO:Orm aracındaki contexttir. Arayüzü application katmanındadır
        /// <summary>
        /// Orm aracındaki contexttir. Arayüzü application katmanındadır
        /// </summary>
        /// <param name="dbContextOptions"></param>
        public ApplicationDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {

        }
        public DbSet<CrmUser> CrmUser { get ; set; }
        public DbSet<CrmTask> CrmTask { get; set; }
        public DbSet<CrmAccount> CrmAccount { get; set; }
    }
}
