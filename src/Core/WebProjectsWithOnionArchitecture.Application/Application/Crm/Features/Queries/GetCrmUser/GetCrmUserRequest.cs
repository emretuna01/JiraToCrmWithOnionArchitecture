using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmUser
{
    public class GetCrmUserRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
