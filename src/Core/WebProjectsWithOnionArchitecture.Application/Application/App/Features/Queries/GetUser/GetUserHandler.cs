using AutoMapper;
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
        private readonly IMapper _mapper;

        public GetUserHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepostitory = userRepository;
            _mapper = mapper;
        }

        public async Task<List<GetUserResponse>> GetUserFromDb()
        {
            return _mapper.Map<List<GetUserResponse>>(await _userRepostitory.GetAsync());           
                   
        }

      
    }
}
