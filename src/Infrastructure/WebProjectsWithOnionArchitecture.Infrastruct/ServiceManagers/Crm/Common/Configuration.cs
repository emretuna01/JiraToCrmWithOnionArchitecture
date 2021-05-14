using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProjectsWithOnionArchitecture.Infrastruct.ServiceManagers.Crm.Common
{
    public class Configuration
    {
        public string CrmDefaultLink { get; set; }
        public string WhoAmI { get; set; }
        public string Task { get; set; }
        public string SystemUser { get; set; }
        //TODO: ContentType type will change from string to string array
        public string ContentType { get; set; }        

    }
}
