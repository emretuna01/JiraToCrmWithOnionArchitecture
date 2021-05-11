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
            var crmusers=await _crmUserRepository.GetCrmUserFromDbByName(getCrmUserRequest.UserName, getCrmUserRequest.Password);
            GetCrmUserResponse getCrmUserResponse = new GetCrmUserResponse()
            {
                BusinessUnitId = crmusers.First().BusinessUnitId,
                UserName = crmusers.First().UserName,
                OdataContext = crmusers.First().OdataContext,
                OrganizationId = crmusers.First().OrganizationId,
                Password = crmusers.First().Password,
                UserId = crmusers.First().UserId
            };
            return  getCrmUserResponse;
        }

    }
}
