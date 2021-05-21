using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUser;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUserByName;
using WebProjectsWithOnionArchitecture.Application.Application.App.Interfaces.Queries;
using WebProjectsWithOnionArchitecture.Infrastruct.ServiceManagers.Crm.Common;

namespace WebProjectsWithOnionArchitecture.Infrastruct.ServiceManagers.Crm.Services
{
    public class CrmServicesUtilities
    {
        //TODO: JWT token architecture will be added        
        private readonly IOptions<Configuration> _configuration;
        private readonly Configuration _bconfiguration;
        private readonly RestSharpFactory _restSharpFactory;
        private readonly GetUserByNameHandler _getUserByNameHandler;



        public CrmServicesUtilities(IOptions<Configuration> configuration, RestSharpFactory restSharpFactory, GetUserByNameHandler getUserByNameHandler, Configuration bconfiguration)
        {

            _configuration = configuration;
            _restSharpFactory = restSharpFactory;
            _getUserByNameHandler = getUserByNameHandler;
            _bconfiguration = bconfiguration;
        }

        public string GetCrmTypeAdress(string parameter)
        {             
            return _configuration.Value.CrmDefaultLink + _configuration.Value.GetType().GetProperty(parameter).GetValue(_configuration.Value);
        }
        public string GetRequestContentType()
        {
            return _configuration.Value.ContentType;
        }
        public async  Task<GetUserByNameResponse> GetUserByNameFromDbCheck(IRequestQuery requestQuery)
        {
            return await _getUserByNameHandler.GetUserByNameFromDb(requestQuery);
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

        public async Task<IRestResponse> RequestRecursiveSender(RestClient restClient, RestRequest restRequest)
        {
            
                IRestResponse result = await restClient.ExecuteAsync(restRequest);
                var jObject = ((JObject)JsonConvert.DeserializeObject(result.Content)).Last;
                return null;

        }




    }
}
