using RestSharp;
using System.Linq;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmUser;

namespace WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Queries.GetCrmUser
{
    public class GetCrmUserHandler
    {
        readonly ICrmUserRepository _crmUserRepository;

        public GetCrmUserHandler(ICrmUserRepository crmUserRepository)
        {
            _crmUserRepository = crmUserRepository;
        }

        public async Task<GetCrmUserResponse> GetCrmUserFromDb()
        {
            return null;
        }

    }
}
