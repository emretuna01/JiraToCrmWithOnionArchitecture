using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUserByName;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Commands.InsertCrmUser;

namespace WebProjectsWithOnionArchitecture.Infrastruct.ServiceManagers.Crm.Services
{
    public class CrmServiceManager
    {
        private readonly CrmServicesUtilities _crmServicesUtilities;
        private readonly InsertCrmUserCommandHandler _insertCrmUserCommandHandler;
        public CrmServiceManager(CrmServicesUtilities crmServicesUtilities, InsertCrmUserCommandHandler insertCrmUserCommandHandler)
        {
            _crmServicesUtilities = crmServicesUtilities;
            _insertCrmUserCommandHandler = insertCrmUserCommandHandler;
        }

        public async Task<IRestResponse> RequestSenderManager(GetUserByNameRequest getUserByNameRequest, Method method = 0)
        {
            var url = _crmServicesUtilities.GetCrmUserAdress();
            var contentType = _crmServicesUtilities.GetRequestContentType();
            var user = _crmServicesUtilities.GetUserByNameFromDbCheck(getUserByNameRequest);
            var authenticator = _crmServicesUtilities.NtlmAuthenticatorByCredentials(user);
            var resClient = _crmServicesUtilities.PrepareRestClient(url, authenticator);
            var resRequest = _crmServicesUtilities.PrepareRestRequest(method, contentType);
            return await _crmServicesUtilities.RequestSender(resClient, resRequest);
        }

        public async Task<InsertCrmUserCommandServiceResponse> InsertCrmUserManager(GetUserByNameRequest getUserByNameRequest, Method method = 0)
        {
            Task<IRestResponse> restResponse = (Task<IRestResponse>)await RequestSenderManager(getUserByNameRequest);
            return await _insertCrmUserCommandHandler.InsertCrmUser(restResponse);
        }



    }


}
