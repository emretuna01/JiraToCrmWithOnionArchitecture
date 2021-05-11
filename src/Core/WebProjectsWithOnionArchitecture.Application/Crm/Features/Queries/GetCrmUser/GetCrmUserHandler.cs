using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.DbRepository;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmUser
{
    public class GetCrmUserHandler
    {
        readonly ICrmUserRepository _crmUserRepository;

        public GetCrmUserHandler(ICrmUserRepository crmUserRepository)
        {
            _crmUserRepository = crmUserRepository;
        }

        public async Task<GetCrmUserResponse> GetCrmUserFromDb(GetCrmUserRequest getCrmUserRequest)
        {
            return null;
        }

    }
}
