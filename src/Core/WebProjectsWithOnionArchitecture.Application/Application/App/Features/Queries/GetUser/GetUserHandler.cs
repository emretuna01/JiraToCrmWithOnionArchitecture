using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Interfaces.DbRepository;


namespace WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUser
{
    public class GetUserHandler
    {
        private readonly IUserRepository _userRepostitory;
        private readonly List<GetUserResponse> _getUserResponse;
        private readonly GetUserResponse __getUserResponse;

        public GetUserHandler(IUserRepository userRepository, List<GetUserResponse> getUserResponses, GetUserResponse response)
        {
            _userRepostitory = userRepository;
            _getUserResponse = getUserResponses;
            __getUserResponse = response;
        }
        public async Task<List<GetUserResponse>> GetUserFromDb()
        {
            var result=await _userRepostitory.GetAsync();
            //TODO:automapper will be added 
            for (int i = 0; i < result.Count; i++)
            {
                __getUserResponse.Guid = result[i].Guid;
                __getUserResponse.IsActive = result[i].IsActive;
                __getUserResponse.LastLoginDateTime = result[i].LastLoginDateTime;
                __getUserResponse.Password = result[i].Password;
                __getUserResponse.UserName = result[i].UserName;
                __getUserResponse.RegisterDateTime = result[i].RegisterDateTime;
                _getUserResponse.Add(__getUserResponse);
            }

            return _getUserResponse;
            
        }

      
    }
}
