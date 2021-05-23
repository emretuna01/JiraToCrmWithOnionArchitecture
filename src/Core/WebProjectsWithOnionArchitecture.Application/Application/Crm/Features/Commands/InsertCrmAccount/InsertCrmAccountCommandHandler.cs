using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Interfaces.DbRepository;

namespace WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Commands.InsertCrmAccount
{
    public class InsertCrmAccountCommandHandler
    {
        private readonly ICrmUserRepository _crmUserRepository;
        private readonly IMapper _mapper;
        private readonly InsertCrmAccountCommandServiceResponse _insertCrmAccountCommandServiceResponse;

        public InsertCrmAccountCommandHandler(ICrmUserRepository crmUserRepository, InsertCrmAccountCommandServiceResponse insertCrmAccountCommandServiceResponse, IMapper mapper)
        {
            _crmUserRepository = crmUserRepository;
            _insertCrmAccountCommandServiceResponse = insertCrmAccountCommandServiceResponse;
            _mapper = mapper;
        }

        public async Task<InsertCrmAccountCommandServiceResponse> InsertCrmAccount(List<string> requestResult)
        {
            JsonConvert.DeserializeObject<>(requestResult);
        }

    }
}
