using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Enums;
using WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Domain.Crm.Entities;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Features.Commands.UpdateCrmUser
{
    public class UpdateCrmUserCommandHandler
    {

        public readonly ICrmUserRepository _crmUserRepository;
        private CrmUser _crmUser;
        private UpdateCrmUserCommandServiceResponse _updateCrmUserCommandServiceResponse;

        public UpdateCrmUserCommandHandler(ICrmUserRepository crmUserRepository)
        {
            _crmUserRepository = crmUserRepository;
        }

        public async Task<UpdateCrmUserCommandServiceResponse> UpdateCrmUser(UpdateCrmUserCommandRequest  updateCrmUserCommandRequest,UpdateCrmUserCommandResponse updateCrmUserCommandResponse)
        {
            _crmUser.UserName = updateCrmUserCommandRequest.UserName;
            _crmUser.Password = updateCrmUserCommandRequest.Password;

            var crmuser= await _crmUserRepository.GetWhereAsync(p => p.UserName.Contains(_crmUser.UserName) && p.Password.Contains(_crmUser.Password));

            //TODO: automapper lib. will be added
            _crmUser.OdataContext   = updateCrmUserCommandResponse.OdataContext;
            _crmUser.BusinessUnitId = updateCrmUserCommandResponse.OdataContext;
            _crmUser.UserId         = updateCrmUserCommandResponse.UserId;
            _crmUser.OrganizationId = updateCrmUserCommandResponse.OrganizationId;
            
            //TODO: crmuser list should be one instance with control count
           var count= await _crmUserRepository.UpdateAsync(_crmUser, crmuser[0].Guid);

            _updateCrmUserCommandServiceResponse.Message = count.ToString() + EnumHolders.ResponseMessages.AddedSuccessfully.ToString();
            _updateCrmUserCommandServiceResponse.IsSuccessfull = count >= 0 ? EnumHolders.ResponseStatus.True.ToString() : EnumHolders.ResponseStatus.False.ToString();

            return _updateCrmUserCommandServiceResponse;

        }

    }
}
