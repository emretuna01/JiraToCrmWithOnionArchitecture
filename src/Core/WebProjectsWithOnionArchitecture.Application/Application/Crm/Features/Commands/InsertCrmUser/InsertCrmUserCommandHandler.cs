using AutoMapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Enums;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities;

namespace WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Commands.InsertCrmUser
{
    public class InsertCrmUserCommandHandler
    {
        private readonly ICrmUserRepository _crmUserRepository;
        private readonly IMapper _mapper;
        private readonly InsertCrmUserCommandServiceResponse _insertCrmUserCommandServiceResponse;

        public InsertCrmUserCommandHandler(ICrmUserRepository crmUserRepository, IMapper mapper, InsertCrmUserCommandServiceResponse insertCrmUserCommandServiceResponse)
        {
            _crmUserRepository = crmUserRepository;
            _mapper = mapper;
            _insertCrmUserCommandServiceResponse = insertCrmUserCommandServiceResponse;
        }

        public async Task<InsertCrmUserCommandServiceResponse> InsertCrmUser(Task<IRestResponse> restResponse)
        {
            var json = JObject.Parse(restResponse.Result.Content)["value"].ToString();
            var insertdata=JsonConvert.DeserializeObject<List<InsertCrmUserCommandResponse>>(json);
            var mappeddata= _mapper.Map<List<CrmUser>>(insertdata);
            var count= await _crmUserRepository.AddRangeAsync(mappeddata);

            _insertCrmUserCommandServiceResponse.Message = count.ToString() + EnumHolders.ResponseMessages.AddedSuccessfully.ToString();
            _insertCrmUserCommandServiceResponse.IsSuccessfull = count >= 0 ? EnumHolders.ResponseStatus.True.ToString() : EnumHolders.ResponseStatus.False.ToString();

            return _insertCrmUserCommandServiceResponse;
        }


    }
}
