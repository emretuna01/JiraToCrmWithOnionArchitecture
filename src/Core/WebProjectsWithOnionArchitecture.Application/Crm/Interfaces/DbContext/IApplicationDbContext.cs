using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.DbContext
{
    public interface IApplicationDbContext
    {
        public DbSet<Object> Crm { get; set; }

    }
}
