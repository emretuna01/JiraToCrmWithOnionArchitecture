using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUserByName;
using WebProjectsWithOnionArchitecture.Application.Application.App.Interfaces.Queries;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Commands.InsertCrmUser;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Queries.GetCrmAccount;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmUser;

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

        public async Task<IRestResponse> RequestSenderManager(IRequestQuery requestQuery,string crmType ,Method method = 0)
        {
            var url = _crmServicesUtilities.GetCrmTypeAdress(crmType);
            var contentType = _crmServicesUtilities.GetRequestContentType();
            var user = _crmServicesUtilities.GetUserByNameFromDbCheck(requestQuery);
            var authenticator = _crmServicesUtilities.NtlmAuthenticatorByCredentials(user);
            var resClient = _crmServicesUtilities.PrepareRestClient(url, authenticator);
            var resRequest = _crmServicesUtilities.PrepareRestRequest(method, contentType);
            return await _crmServicesUtilities.RequestSender(resClient, resRequest);
        }

        public async Task<string> GetCrmUserManager(GetCrmUserRequest getCrmUserRequest, string crmType= "SystemUser")
        {
            return (await RequestSenderManager(getCrmUserRequest, crmType)).Content;
        }

        public async Task<InsertCrmUserCommandServiceResponse> InsertCrmUserManager(GetUserByNameRequest getUserByNameRequest, string crmType= "SystemUser")
        {
            IRestResponse restResponse = await RequestSenderManager(getUserByNameRequest, crmType);
            return await _insertCrmUserCommandHandler.InsertCrmUser(restResponse);
        }

        public async Task<string> GetCrmAccountManager(GetCrmAccountRequest getCrmAccountRequest, string crmType = "Account")
        {
            return (await RequestSenderManager(getCrmAccountRequest, crmType)).Content;
        }



    }


}
