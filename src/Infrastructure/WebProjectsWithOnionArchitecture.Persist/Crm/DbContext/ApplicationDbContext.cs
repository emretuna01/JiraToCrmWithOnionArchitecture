﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.DbContext;

namespace WebProjectsWithOnionArchitecture.Persist.DbContext
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext, IApplicationDbContext
    {
        public DbSet<object> Crm { get ; set; }
    }
}
