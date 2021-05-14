using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProjectsWithOnionArchitecture.Infrastruct.ServiceManagers.Crm.Common
{
    public class RestSharpFactory
    {
        private RestClient _restClient;
        public RestClient RestClient { get { return _restClient; } set { _restClient = value; } }

        private RestRequest _restRequest;
        public RestRequest RestRequest { get { return _restRequest; } set { _restRequest = value; } }

        private NtlmAuthenticator _ntlmAuthenticator;
        public NtlmAuthenticator NtlmAuthenticator { get { return _ntlmAuthenticator; } set { _ntlmAuthenticator = value; } }


    }
}
