using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Domain.Entities.App.Entities;

namespace WebProjectsWithOnionArchitecture.Application.Application.App.Interfaces.DbRepository
{
    public interface IUserRepository:IDbRepository<User>
    {
    }
}
