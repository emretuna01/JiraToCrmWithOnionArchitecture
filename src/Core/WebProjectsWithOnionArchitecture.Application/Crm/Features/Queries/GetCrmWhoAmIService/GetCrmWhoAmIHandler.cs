using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.DbRepository;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmWhoAmIService
{
    public class GetCrmWhoAmIHandler
    {
        public readonly ICrmUserRepository _crmUserRepository;

        public GetCrmWhoAmIHandler(ICrmUserRepository crmUserRepository)
        {
            _crmUserRepository = crmUserRepository;
        }





    }
}
