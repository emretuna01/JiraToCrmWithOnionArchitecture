using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmUser
{
    public class GetCrmUserResponse
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string OdataContext { get; set; }
        public string BusinessUnitId { get; set; }
        public string UserId { get; set; }
        public string OrganizationId { get; set; }
    }
}
