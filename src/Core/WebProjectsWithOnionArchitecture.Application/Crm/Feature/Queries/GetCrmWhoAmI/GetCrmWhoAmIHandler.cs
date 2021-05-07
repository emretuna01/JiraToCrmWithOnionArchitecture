using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.DbRepository;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Feature.Queries.GetCrmWhoAmI
{
    public class GetCrmWhoAmIHandler
    {
        readonly ICrmUserRepository _crmUserRepository;

        public GetCrmWhoAmIHandler(ICrmUserRepository crmUserRepository)
        {
            _crmUserRepository = crmUserRepository;
        }

        public async Task<List<GetCrmWhoAmIResponse>> GetWhoAmI(GetCrmWhoAmIRequest getCrmWhoAmIRequest)
        {
            var crmUser = await _crmUserRepository.GetAsync();
            return crmUser.Select(p => new GetCrmWhoAmIResponse { UserName = p.UserName, Password = p.Password }).ToList();
        }
    }
}
