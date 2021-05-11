using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Commands.InsertCrmUser;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmUser;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmWhoAmI;

namespace WebProjectsWithOnionArchitecture.Infrastruct.Controllers.CrmControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrmController : ControllerBase
    {
        //mediatR library will be added here
        public readonly InsertCrmUserCommandHandler _insertCrmUserCommandHandler;
        public readonly GetCrmUserHandler _getCrmUserHandler;

        public CrmController(InsertCrmUserCommandHandler insertCrmUserCommandHandler, GetCrmUserHandler getCrmUserHandler)
        {
            _insertCrmUserCommandHandler = insertCrmUserCommandHandler;
            _getCrmUserHandler = getCrmUserHandler;
        }
        
        [HttpPost("addcrmuser")]       
        public async Task<InsertCrmUserCommandResponse> AddCrmUserToDb(InsertCrmUserCommandRequest insertCrmUserCommandRequest)
        {               
            return await _insertCrmUserCommandHandler.AddToDb(insertCrmUserCommandRequest);
        }
       
        [HttpPost("getcrmuser")]
        public async Task<GetCrmUserResponse> GetCrmUserFromDbByName(GetCrmUserRequest getCrmUserRequest)
        {
            return await _getCrmUserHandler.GetCrmUserFromDb(getCrmUserRequest);
        }
        

    }
}
