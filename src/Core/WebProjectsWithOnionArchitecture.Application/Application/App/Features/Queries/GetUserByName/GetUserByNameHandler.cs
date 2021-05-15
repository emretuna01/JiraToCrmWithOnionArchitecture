﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUser;
using WebProjectsWithOnionArchitecture.Application.Application.App.Interfaces.DbRepository;

namespace WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUserByName
{
    public class GetUserByNameHandler
    {
        private readonly IUserRepository _userRepostitory;        
        private readonly GetUserByNameResponse _getUserByNameResponse;

        public GetUserByNameHandler(IUserRepository userRepository, GetUserByNameResponse getUserByNameResponse)
        {
            _userRepostitory       = userRepository;
            _getUserByNameResponse = getUserByNameResponse;
        }

        public async Task<GetUserByNameResponse> GetUserByNameFromDb(GetUserByNameRequest getUserByNameRequest)
        {
            var result = await _userRepostitory.GetWhereAsync(p=> p.UserName.Contains(getUserByNameRequest.UserName) && p.Password.Contains(getUserByNameRequest.Password));
            
            //TODO:automapper will be added 
            _getUserByNameResponse.Guid = result.Guid;
            _getUserByNameResponse.IsActive = result.IsActive;
            _getUserByNameResponse.LastLoginDateTime= result.LastLoginDateTime;
            _getUserByNameResponse.Password= result.Password;
            _getUserByNameResponse.RegisterDateTime= result.RegisterDateTime;
            _getUserByNameResponse.UserName= result.UserName;

            return _getUserByNameResponse;

        }

    }
}