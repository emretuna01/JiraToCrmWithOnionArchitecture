using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Domain.Entities.App.Entities;
using WebProjectsWithOnionArchitecture.Persist.Persist.App.Common;
using WebProjectsWithOnionArchitecture.Persist.Persist.Crm.DbContext;

namespace WebProjectsWithOnionArchitecture.Persist.Persist.App.Persist.DbRepositories
{
    public class UserRepository:DbRepository<User>,IUserRepository
    {
        public UserRepository(ApplicationCrmDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
