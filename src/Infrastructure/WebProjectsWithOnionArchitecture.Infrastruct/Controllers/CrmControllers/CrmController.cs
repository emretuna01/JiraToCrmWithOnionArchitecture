using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Crm.Feature.Queries.GetCrmWhoAmI;

namespace WebProjectsWithOnionArchitecture.Infrastruct.Controllers.CrmControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrmController : ControllerBase
    {
        GetCrmWhoAmIHandler _getCrmWhoAmIHandler;

        public CrmController(GetCrmWhoAmIHandler getCrmWhoAmIHandler)
        {
            _getCrmWhoAmIHandler = getCrmWhoAmIHandler;
        }

        public async Task<List<GetCrmWhoAmIResponse>> Get()
        {
            List<GetCrmWhoAmIResponse> getCrmWhoAmIResponses= await _getCrmWhoAmIHandler.GetWhoAmI(new GetCrmWhoAmIRequest());
            return getCrmWhoAmIResponses;
        }
    }
}
