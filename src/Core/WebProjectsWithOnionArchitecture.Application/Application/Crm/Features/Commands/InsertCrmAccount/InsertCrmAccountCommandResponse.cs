using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Commands.InsertCrmAccount
{
    public class InsertCrmAccountCommandResponse
    {
        [JsonProperty("@odata.etag")]
        public string OdataEtag { get; set; }
        public string name { get; set; }
        public int statecode { get; set; }
        public string accountid { get; set; }
    }
}
