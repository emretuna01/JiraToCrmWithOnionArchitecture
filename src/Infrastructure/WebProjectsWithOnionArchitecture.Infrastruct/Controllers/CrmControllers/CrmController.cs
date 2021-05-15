using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUserByName;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Commands.InsertCrmUser;
using WebProjectsWithOnionArchitecture.Infrastruct.ServiceManagers.Crm.Services;

namespace WebProjectsWithOnionArchitecture.Infrastruct.Controllers.CrmControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrmController : ControllerBase
    {
        private readonly CrmServiceManager _crmServiceManager;
        public CrmController(CrmServiceManager crmServiceManager)
        {
            _crmServiceManager = crmServiceManager;
        }

        [HttpPost("getcrmuser")]
        public async Task<string> GetCrmUserFromService(GetUserByNameRequest getUserByNameRequest)
        {
            return (await _crmServiceManager.RequestSenderManager(getUserByNameRequest)).Content;
        }

        [HttpPost("insertcrmuser")]
        public async Task<InsertCrmUserCommandServiceResponse> InsertCrmUserFromService(GetUserByNameRequest getUserByNameRequest)
        {
            return await _crmServiceManager.InsertCrmUserManager(getUserByNameRequest);
        }



    }
}
