using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Domain.Crm.Entities;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.DbRepository
{
    public interface ICrmAccount : IDbRepository<CrmAccount>
    {
    }
}
