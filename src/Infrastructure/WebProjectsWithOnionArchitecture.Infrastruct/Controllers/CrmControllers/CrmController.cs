using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Commands.InsertCrmUser;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmUser;

namespace WebProjectsWithOnionArchitecture.Infrastruct.Controllers.CrmControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrmController : ControllerBase
    {
        //TODO:mediatR library will be added here
       // public readonly InsertCrmUserCommandHandler _insertCrmUserCommandHandler;
       // public readonly GetCrmUserHandler _getCrmUserHandler;

        public CrmController()
        {
          
        }
        
        [HttpPost("adduser")]       
        public async Task<InsertCrmUserCommandResponse> AddCrmUserToDb(InsertCrmUserCommandRequest insertCrmUserCommandRequest)
        {
            return null;
        }
       
        [HttpPost("getcrmuser")]
        public async Task<GetCrmUserResponse> GetCrmUserFromDbByName(GetCrmUserRequest getCrmUserRequest)
        {
            return null;
        }
        

    }
}
