using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Commands.InsertUser;
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

       private readonly InsertUserCommandHandler _insertUserCommandHandler;

        public CrmController(InsertUserCommandHandler insertUserCommandHandler)
        {
            _insertUserCommandHandler = insertUserCommandHandler;
        }
        
        [HttpPost("adduser")]       
        public async Task<InsertUserCommandResponse> AddCrmUserToDb(InsertUserCommandRequest insertCrmUserCommandRequest)
        {
            return await _insertUserCommandHandler.InsertUserToDb(insertCrmUserCommandRequest);
        }
       
        [HttpPost("getcrmuser")]
        public async Task<GetCrmUserResponse> GetCrmUserFromDbByName(GetCrmUserRequest getCrmUserRequest)
        {
            void test(){};

            return null;

        }
        

    }
}
