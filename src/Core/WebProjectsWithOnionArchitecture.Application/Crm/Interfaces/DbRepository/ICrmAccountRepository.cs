using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.DbRepository
{
    public interface ICrmAccountRepository : IDbRepository<CrmAccount>
    {
    }
}
