using AutoMapper;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmUser;

namespace WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Queries.GetCrmUser
{
    public class GetCrmUserHandler
    {
        private readonly ICrmUserRepository _crmUserRepository;
        private readonly IMapper _mapper;
        public GetCrmUserHandler(ICrmUserRepository crmUserRepository, IMapper mapper)
        {
            _crmUserRepository = crmUserRepository;
            _mapper = mapper;
        }

        public async Task<List<GetCrmUserResponse>> GetCrmUserFromDb()
        {
            return  _mapper.Map<List<GetCrmUserResponse>>(await _crmUserRepository.GetAsync());            
        }

    }
}
