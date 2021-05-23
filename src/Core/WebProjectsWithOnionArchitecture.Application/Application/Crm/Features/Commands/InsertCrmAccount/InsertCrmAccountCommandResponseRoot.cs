using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Commands.InsertCrmAccount
{
    public class InsertCrmAccountCommandResponseRoot
    {
        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }
        public List<InsertCrmAccountCommandResponse> InsertCrmAccountCommandResponse { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string OdataNextLink { get; set; }
    }
}
