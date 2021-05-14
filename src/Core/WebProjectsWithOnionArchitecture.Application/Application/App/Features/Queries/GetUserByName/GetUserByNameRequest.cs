using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUserByName
{
    public class GetUserByNameRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
