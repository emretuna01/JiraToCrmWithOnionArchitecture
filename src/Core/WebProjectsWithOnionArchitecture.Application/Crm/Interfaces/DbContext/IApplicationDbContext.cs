using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Domain.Crm.Entities;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.DbContext
{
    /// <summary>
    /// Orm aracındaki persistence katmanında contextin arayüzüdür.
    /// </summary>
    public interface IApplicationDbContext
    {
        public DbSet<CrmUser> CrmUser { get; set; }

    }
}
