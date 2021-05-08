using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmWhoAmI;

namespace WebProjectsWithOnionArchitecture.Infrastruct.Controllers.CrmControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrmController : ControllerBase
    {
        readonly GetCrmWhoAmIHandler _getCrmWhoAmIHandler;

        public CrmController(GetCrmWhoAmIHandler getCrmWhoAmIHandler)
        {
            _getCrmWhoAmIHandler = getCrmWhoAmIHandler;
        }

        public async Task<GetCrmWhoAmIResponse> CrmWhoAmI(GetCrmWhoAmIRequest getCrmWhoIAmRequest)
        {
            return await _getCrmWhoAmIHandler.GetWhoAmI(getCrmWhoIAmRequest);
        }


    }
}
