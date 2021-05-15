using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUserByName;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Commands.InsertCrmUser;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Queries.GetCrmUser;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmUser;
using WebProjectsWithOnionArchitecture.Infrastruct.ServiceManagers.Crm.Services;

namespace WebProjectsWithOnionArchitecture.Infrastruct.Controllers.CrmControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrmController : ControllerBase
    {
        private readonly CrmServiceManager _crmServiceManager;
        private readonly GetCrmUserHandler _getCrmUserHandler;
        public CrmController(CrmServiceManager crmServiceManager, GetCrmUserHandler getCrmUserHandler)
        {
            _crmServiceManager = crmServiceManager;
            _getCrmUserHandler = getCrmUserHandler;
        }

        [HttpPost("getcrmuserfromservice")]
        public async Task<string> GetCrmUserFromService(GetCrmUserRequest getCrmUserRequest)
        {
            return (await _crmServiceManager.RequestSenderManager(getCrmUserRequest)).Content;
        }

        [HttpPost("insertcrmuser")]
        public async Task<InsertCrmUserCommandServiceResponse> InsertCrmUserFromService(GetUserByNameRequest getUserByNameRequest)
        {
            return await _crmServiceManager.InsertCrmUserManager(getUserByNameRequest);
        }

        [HttpGet("getcrmuserfromdb")]
        public async Task<List<GetCrmUserResponse>> GetCrmUserFromDb()
        {
            return await _getCrmUserHandler.GetCrmUserFromDb();
        }



    }
}
