using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUserByName;

namespace WebProjectsWithOnionArchitecture.Infrastruct.ServiceManagers.Crm.Services
{
    public class CrmServiceManager
    {
        private readonly CrmServicesUtilities _crmServicesUtilities;
        public CrmServiceManager(CrmServicesUtilities crmServicesUtilities)
        {
            _crmServicesUtilities = crmServicesUtilities;

        }

        public IRestResponse RequestSenderManager(GetUserByNameRequest getUserByNameRequest, Method method,string contentType)
        {
            var url = _crmServicesUtilities.GetCrmUserAdress();
            var user = _crmServicesUtilities.GetUserByNameFromDbCheck(getUserByNameRequest);
            var authenticator = _crmServicesUtilities.NtlmAuthenticatorByCredentials(user);
            var resClient = _crmServicesUtilities.PrepareRestClient(url, authenticator);
            var resRequest = _crmServicesUtilities.PrepareRestRequest(method, contentType);
            return _crmServicesUtilities.RequestSender(resClient, resRequest);
        }




}

    
}
