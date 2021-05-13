using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUser
{
    public class GetUserResponse
    {
        public Guid Guid { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }       
        public DateTime? RegisterDateTime { get; set; }       
        public DateTime? LastLoginDateTime { get; set; }       
        public bool? IsActive { get; set; }
    }
}
