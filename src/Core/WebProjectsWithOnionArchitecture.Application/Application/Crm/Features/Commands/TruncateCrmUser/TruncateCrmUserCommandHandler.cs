using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Enums;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUserByName;
using WebProjectsWithOnionArchitecture.Application.Application.App.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Features.Commands.TruncateCrmUser
{
    public class TruncateCrmUserCommandHandler
    {

        private readonly ICrmUserRepository _crmUserRepository;
        private readonly GetUserByNameHandler _getUserByNameHandler;
        private readonly TruncateCrmUserCommandServiceResponse _truncateCrmUserCommandServiceResponse;


        public TruncateCrmUserCommandHandler(ICrmUserRepository crmUserRepository, GetUserByNameHandler getUserByNameHandler, TruncateCrmUserCommandServiceResponse truncateCrmUserCommandServiceResponse)
        {
            _crmUserRepository = crmUserRepository;
            _getUserByNameHandler = getUserByNameHandler;
            _truncateCrmUserCommandServiceResponse = truncateCrmUserCommandServiceResponse;
        }

        public async Task<TruncateCrmUserCommandServiceResponse> TruncateCrmUser(TruncateCrmUserCommandRequest truncateCrmUserCommandRequest)
        {
            var result= await _getUserByNameHandler.CheckUserByNameFromDb(truncateCrmUserCommandRequest);
            var count=  result == true ? await _crmUserRepository.TruncateAsync() : 0;

            _truncateCrmUserCommandServiceResponse.Message = count.ToString() + EnumHolders.ResponseMessages.Added.ToString();
            _truncateCrmUserCommandServiceResponse.IsSuccessfull = count >= 0 ? EnumHolders.ResponseStatus.True.ToString() : EnumHolders.ResponseStatus.False.ToString();
            return _truncateCrmUserCommandServiceResponse;

        }

    }
}
