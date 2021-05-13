using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Infrastruct.ServiceManagers.Crm.Common;

namespace WebProjectsWithOnionArchitecture.Infrastruct.ServiceManagers.Crm.Services
{
    public class CrmServices
    {
        //JWT token architecture will be added

        private readonly NtlmAuthenticator _ntlmAuthenticator;
        private readonly IOptions<Configuration>  _configuration;
        public CrmServices(NtlmAuthenticator ntlmAuthenticator, IOptions<Configuration> configuration)
        {
            _ntlmAuthenticator = ntlmAuthenticator;
            _configuration = configuration;
        }

        public string GetUserAdress()
        {
            var test = _configuration;            
            return null;
        }
        



    }
}
