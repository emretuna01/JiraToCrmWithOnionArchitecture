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
        private readonly List<string> _resultResponseList;
        public CrmServiceManager(CrmServicesUtilities crmServicesUtilities, InsertCrmUserCommandHandler insertCrmUserCommandHandler, List<string> resultResponseList)
        {
            _crmServicesUtilities = crmServicesUtilities;
            _insertCrmUserCommandHandler = insertCrmUserCommandHandler;
            _resultResponseList = resultResponseList;
        }

        public async Task<IRestResponse>  RequestSenderManager(IRequestQuery requestQuery,string crmType ,Method method = 0)
        {
            var url = _crmServicesUtilities.GetCrmTypeAdress(crmType);
            var contentType = _crmServicesUtilities.GetRequestContentType();
            var user = _crmServicesUtilities.GetUserByNameFromDbCheck(requestQuery);
            var authenticator = _crmServicesUtilities.NtlmAuthenticatorByCredentials(user);
            var resClient = _crmServicesUtilities.PrepareRestClient(url, authenticator);
            var resRequest = _crmServicesUtilities.PrepareRestRequest(method, contentType);
            return await _crmServicesUtilities.RequestSender(resClient, resRequest);
        }

        public async Task<List<string>> RequestRecursiveSenderManager(IRequestQuery requestQuery, string crmType, Method method = 0)
        {
            Tuple<IRestResponse, String> resultTuple;
            var url = _crmServicesUtilities.GetCrmTypeAdress(crmType);
            var contentType = _crmServicesUtilities.GetRequestContentType();
            var resRequest = _crmServicesUtilities.PrepareRestRequest(method, contentType);
            var user = _crmServicesUtilities.GetUserByNameFromDbCheck(requestQuery);
            var authenticator = _crmServicesUtilities.NtlmAuthenticatorByCredentials(user);
            do
            {
                var resClient = _crmServicesUtilities.PrepareRestClient(url, authenticator);
                resultTuple = await _crmServicesUtilities.RequestRecursiveSender(resClient, resRequest);
                _resultResponseList.Add(resultTuple.Item1.Content);
                url = String.IsNullOrEmpty(resultTuple.Item2) ? null : resultTuple.Item2;
            } while (String.IsNullOrEmpty(resultTuple.Item2) == false);

            return _resultResponseList;
        }

        public async Task<string>GetCrmUserManager(GetCrmUserRequest getCrmUserRequest, string crmType= "SystemUser")
        {
            return (await RequestSenderManager(getCrmUserRequest, crmType)).Content;
        }

        public async Task<InsertCrmUserCommandServiceResponse> InsertCrmUserManager(GetUserByNameRequest getUserByNameRequest, string crmType= "SystemUser")
        {
            IRestResponse restResponse = await RequestSenderManager(getUserByNameRequest, crmType);
            return await _insertCrmUserCommandHandler.InsertCrmUser(restResponse);
        }

        public async Task<List<string>> GetCrmAccountManager(GetCrmAccountRequest getCrmAccountRequest, string crmType = "Account")
        {
            return (await RequestRecursiveSenderManager(getCrmAccountRequest, crmType));
        }
        public async Task<InsertCrmAccountCommandServiceResponse> GetCrmAccountManager(GetCrmAccountRequest getCrmAccountRequest, string crmType = "Account")
        {
            return (await RequestRecursiveSenderManager(getCrmAccountRequest, crmType));
        }



    }


}
