using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUser;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUserByName;
using WebProjectsWithOnionArchitecture.Infrastruct.ServiceManagers.Crm.Common;

namespace WebProjectsWithOnionArchitecture.Infrastruct.ServiceManagers.Crm.Services
{
    public class CrmServicesUtilities
    {
        //TODO: JWT token architecture will be added        
        private readonly IOptions<Configuration> _configuration;
        private readonly RestSharpFactory _restSharpFactory;
        private readonly GetUserByNameHandler _getUserByNameHandler;
        


        public CrmServicesUtilities(IOptions<Configuration> configuration, RestSharpFactory restSharpFactory, GetUserByNameHandler getUserByNameHandler)
        {

            _configuration = configuration;
            _restSharpFactory = restSharpFactory;
            _getUserByNameHandler = getUserByNameHandler;
        }

        public string GetCrmUserAdress()
        {
            return _configuration.Value.CrmDefaultLink + _configuration.Value.SystemUser;
        }
        public string GetRequestContentType()
        {
            return _configuration.Value.ContentType;
        }
        public async  Task<GetUserByNameResponse> GetUserByNameFromDbCheck(GetUserByNameRequest getUserByNameRequest)
        {
            return await _getUserByNameHandler.GetUserByNameFromDb(getUserByNameRequest);
        }

        public NtlmAuthenticator NtlmAuthenticatorByCredentials(Task<GetUserByNameResponse> getUserByNameResponse)
        {
            //TODO: instead of new keyword find another solution
            return _restSharpFactory.NtlmAuthenticator = new NtlmAuthenticator(getUserByNameResponse.Result.UserName, getUserByNameResponse.Result.Password);
        }

        public RestClient PrepareRestClient(string url, NtlmAuthenticator ntlmAuthenticator, int timeout = -1)
        {
            //TODO: instead of new keyword find another solution
            _restSharpFactory.RestClient = new RestClient(url);
            _restSharpFactory.RestClient.Timeout = timeout;
            _restSharpFactory.RestClient.Authenticator = ntlmAuthenticator;
            return _restSharpFactory.RestClient;

        }

        public RestRequest PrepareRestRequest(Method method, string contentType)
        {
            //TODO: instead of new keyword find another solution
            _restSharpFactory.RestRequest = new RestRequest(method);
            _restSharpFactory.RestRequest.AddHeader("Content-Type", contentType);
            return _restSharpFactory.RestRequest;
        }        

        public async Task<IRestResponse> RequestSender(RestClient restClient, RestRequest restRequest)
        {
            return await restClient.ExecuteAsync(restRequest);
        }

        



    }
}
