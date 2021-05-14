using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Commands.InsertUser;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUser;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUserByName;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmUser;
using WebProjectsWithOnionArchitecture.Infrastruct.ServiceManagers.Crm.Services;

namespace WebProjectsWithOnionArchitecture.Infrastruct.Controllers.CrmControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrmController : ControllerBase
    {

        private readonly InsertUserCommandHandler _insertUserCommandHandler;
        private readonly GetUserHandler _getUserHandler;
        private readonly CrmServiceManager _crmServiceManager;
        

        public CrmController(InsertUserCommandHandler insertUserCommandHandler, GetUserHandler getUserHandler, CrmServiceManager crmServiceManager)
        {
            _insertUserCommandHandler = insertUserCommandHandler;
            _getUserHandler = getUserHandler;
            _crmServiceManager = crmServiceManager;
        }
        
        [HttpPost("adduser")]       
        public async Task<InsertUserCommandResponse> AddCrmUserToDb(InsertUserCommandRequest insertCrmUserCommandRequest)
        {
            return await _insertUserCommandHandler.InsertUserToDb(insertCrmUserCommandRequest);
        }

        [HttpGet("getuser")]
        public async Task<List<GetUserResponse>> GetUserToDb()
        {
            return await _getUserHandler.GetUserFromDb();
        }

        
        [HttpPost("getcrmuser")]
        public async Task<GetCrmUserResponse> GetCrmUserFromService(GetUserByNameRequest  getUserByNameRequest)
        {
           var test=  await _crmServiceManager.RequestSenderManager(getUserByNameRequest);
            return null;
        }
        

    }
}
