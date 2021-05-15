using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Interfaces.Queries;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Features.Commands.UpdateCrmUser
{
    public class UpdateCrmUserCommandRequest : IRequestQuery
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
