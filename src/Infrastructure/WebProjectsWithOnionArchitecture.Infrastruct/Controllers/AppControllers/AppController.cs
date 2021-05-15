using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Commands.InsertUser;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUser;

namespace WebProjectsWithOnionArchitecture.Infrastruct.Controllers.AppControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        private readonly InsertUserCommandHandler _insertUserCommandHandler;
        private readonly GetUserHandler _getUserHandler;
        public AppController(InsertUserCommandHandler insertUserCommandHandler, GetUserHandler getUserHandler)
        {
            _insertUserCommandHandler = insertUserCommandHandler;
            _getUserHandler = getUserHandler;
        }
        [HttpPost("insertuser")]
        public async Task<InsertUserCommandResponse> AddCrmUserToDb(InsertUserCommandRequest insertCrmUserCommandRequest)
        {
            return await _insertUserCommandHandler.InsertUserToDb(insertCrmUserCommandRequest);
        }

        [HttpGet("getuser")]
        public async Task<List<GetUserResponse>> GetUserToDb()
        {
            return await _getUserHandler.GetUserFromDb();
        }



    }
}
