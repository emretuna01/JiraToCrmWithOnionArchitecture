using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebProjectsWithOnionArchitecture.Domain.Entities.App.Entities;

namespace WebProjectsWithOnionArchitecture.Application.Application.App.Interfaces.DbContext
{
    public interface IApplicationDbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
