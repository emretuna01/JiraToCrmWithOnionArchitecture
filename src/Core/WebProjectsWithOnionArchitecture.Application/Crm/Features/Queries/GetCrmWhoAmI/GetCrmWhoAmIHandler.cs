using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.DbRepository;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmWhoAmI
{
    public class GetCrmWhoAmIHandler
    {
        readonly ICrmUserRepository _crmUserRepository;

        public GetCrmWhoAmIHandler(ICrmUserRepository crmUserRepository)
        {
            _crmUserRepository = crmUserRepository;
        }

        public async Task<GetCrmWhoAmIResponse> GetWhoAmI(GetCrmWhoAmIRequest getCrmWhoAmIRequest)
        {
            var crmUser = await _crmUserRepository.GetAsync();
            return (GetCrmWhoAmIResponse)crmUser.Select(p => new GetCrmWhoAmIResponse { UserName = p.UserName, Password = p.Password });
        }
    }
}
