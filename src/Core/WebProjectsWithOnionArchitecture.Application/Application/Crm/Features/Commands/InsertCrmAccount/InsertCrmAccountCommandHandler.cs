using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Enums;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities;

namespace WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Commands.InsertCrmAccount
{
    public class InsertCrmAccountCommandHandler
    {
        private readonly ICrmAccountRepository _crmAccountRepository;
        private readonly IMapper _mapper;
        private readonly InsertCrmAccountCommandServiceResponse _insertCrmAccountCommandServiceResponse;


        public InsertCrmAccountCommandHandler(ICrmAccountRepository crmAccountRepository, InsertCrmAccountCommandServiceResponse insertCrmAccountCommandServiceResponse, IMapper mapper)
        {
            _crmAccountRepository = crmAccountRepository;
            _insertCrmAccountCommandServiceResponse = insertCrmAccountCommandServiceResponse;
            _mapper = mapper;
        }

        public async Task<InsertCrmAccountCommandServiceResponse> InsertCrmAccount(List<string> requestResult)
        {
            int count =0;

            foreach (var result in requestResult)
            {
                var insertData = JsonConvert.DeserializeObject<InsertCrmAccountCommandResponseRoot>(result);
          
                var mappedData = _mapper.Map<CrmAccountRoot>(insertData);
            
                count = count + await _crmAccountRepository.AddAsync(mappedData);
           
            }

            _insertCrmAccountCommandServiceResponse.Message = count.ToString() + EnumHolders.ResponseMessages.Added.ToString();
            _insertCrmAccountCommandServiceResponse.IsSuccessfull = count >= 0 ? EnumHolders.ResponseStatus.True.ToString() : EnumHolders.ResponseStatus.False.ToString();
            return _insertCrmAccountCommandServiceResponse;
        }

    }
}
