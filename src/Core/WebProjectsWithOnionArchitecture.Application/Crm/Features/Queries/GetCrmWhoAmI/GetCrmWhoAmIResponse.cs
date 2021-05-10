using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmWhoAmI
{
    public class GetCrmWhoAmIResponse
    {
        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }
        public string BusinessUnitId { get; set; }
        public string UserId { get; set; }
        public string OrganizationId { get; set; }

    }
}
