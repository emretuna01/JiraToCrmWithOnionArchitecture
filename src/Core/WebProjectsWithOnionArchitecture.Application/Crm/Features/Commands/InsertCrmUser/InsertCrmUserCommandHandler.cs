using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Enums;
using WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Domain.Crm.Entities;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Features.Commands.InsertCrmUser
{
    public class InsertCrmUserCommandHandler
    {
        readonly ICrmUserRepository _crmUserRepository;
        private CrmUser _crmUser;
        private InsertCrmUserCommandResponse _insertCrmUserCommandResponse;

        public InsertCrmUserCommandHandler(ICrmUserRepository  crmUserRepository,CrmUser crmUser, InsertCrmUserCommandResponse insertCrmUserCommandResponse)
        {
            _crmUserRepository = crmUserRepository;
            _crmUser = crmUser;
            _insertCrmUserCommandResponse = insertCrmUserCommandResponse;
        }

        public async Task<InsertCrmUserCommandResponse> AddToDb(InsertCrmUserCommandRequest insertCrmUserCommandRequest)
        {
            //TODO: automapper library will be added here
            _crmUser.UserName = insertCrmUserCommandRequest.UserName;
            _crmUser.Password = insertCrmUserCommandRequest.Password; 

             var count= await _crmUserRepository.AddAsync(_crmUser);

            var test1 = count.ToString();
            var test2 = EnumHolders.ResponseMessages.AddedSuccessfully.ToString();
            var test = test1 + test2;

            _insertCrmUserCommandResponse.Message = count.ToString() +" "+ EnumHolders.ResponseMessages.AddedSuccessfully.ToString();
            _insertCrmUserCommandResponse.IsSuccessfull = count >= 0 ? EnumHolders.ResponseStatus.True.ToString() : EnumHolders.ResponseStatus.False.ToString();

            return _insertCrmUserCommandResponse;
        }
    }
}
